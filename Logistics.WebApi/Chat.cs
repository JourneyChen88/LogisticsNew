﻿using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.WebApi
{
    public class Chat : Hub
    {
        public static ConcurrentDictionary<string, OnlineClient> OnlineClients = new ConcurrentDictionary<string, OnlineClient>();

        private static readonly object SyncObj = new object();
        public Chat()
        {
        }

        #region msgbus连接
        public override async Task OnConnectedAsync()
        {
            try
            {
                var http = Context.GetHttpContext();
                var key = http.Request.Query["identifier"].ToString();
                OnlineClient client;
                lock (SyncObj)
                {
                    OnlineClients.TryGetValue(key, out client);
                }
                if (client != null)
                {
                    client.ConnectionIds.Add(Context.ConnectionId);
                    client.NickName = http.Request.Query["nickname"];
                    client.Avatar = http.Request.Query["avatar"];
                    client.Identifier = key;
                    client.GroupId = http.Request.Query["groupid"];
                }
                else
                {
                    client = new OnlineClient()
                    {
                        NickName = http.Request.Query["nickname"],
                        Avatar = http.Request.Query["avatar"],
                        Identifier = key,
                        GroupId = http.Request.Query["groupid"],
                        ConnectionIds = new List<string>() { Context.ConnectionId }
                    };
                }
                lock (SyncObj)
                {
                    OnlineClients[client.Identifier] = client;
                }
                Console.WriteLine($"OnConnectedAsync:NickName:{client.NickName},Avatar:{client.Avatar},ConnectionId:{Context.ConnectionId},Identifier:{client.Identifier},GroupId:{client.GroupId},当前链接人数{OnlineClients.Count}");
                await base.OnConnectedAsync();
                if (!string.IsNullOrWhiteSpace(client.GroupId))
                {
                    await Groups.AddToGroupAsync(Context.ConnectionId, client.GroupId);
                }
                //await Clients.GroupExcept(client.GroupId, new[] { client.Identifier }).SendAsync("system", $"用户{client.NickName}加入了群聊");
                //await Clients.Client(client.Identifier).SendAsync("system", $"成功加入{client.GroupId}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public override async Task OnDisconnectedAsync(Exception exception)
        {
            try
            {
                await base.OnDisconnectedAsync(exception);
                bool isRemoved;
                OnlineClient client;
                var http = Context.GetHttpContext();
                var key = http.Request.Query["identifier"].ToString();
                lock (SyncObj)
                {
                    isRemoved = OnlineClients.TryRemove(key, out client);
                }

                Console.WriteLine($"OnDisconnectedAsync:NickName:{client.NickName},Avatar:{client.Avatar},ConnectionId:{Context.ConnectionId},Identifier:{client.Identifier},GroupId:{client.GroupId},当前ConnectionId条数:{client.ConnectionIds.Count},当前链接人数{OnlineClients.Count}");
                if (!string.IsNullOrWhiteSpace(client.GroupId))
                {
                    await Groups.RemoveFromGroupAsync(Context.ConnectionId, client.GroupId);
                }
                //if (isRemoved)
                //{
                //    await Clients.GroupExcept(client.GroupId, client.ConnectionIds).SendAsync("system", $"用户{client.NickName}加入了群聊");
                //}

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        #endregion

        /// <summary>
        /// 演示方法
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public async Task SendMessageToAll(Message msg)
        {
            OnlineClient client;
            lock (SyncObj)
            {
                OnlineClients.TryGetValue(msg.From, out client);
            }
            Console.WriteLine($"SendMessage:user{msg.From},message{msg.Content}");
            await Clients.All.SendAsync("SendMessage", msg);//发给全部
        }

        /// <summary>
        /// 演示方法
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public async Task SendMessageToUser(Message msg)
        {
            OnlineClient client;
            lock (SyncObj)
            {
                OnlineClients.TryGetValue(msg.From, out client);
            }
            Console.WriteLine($"SendMessage:From:{msg.From},To:{msg.To},message{msg.Content}");

            await Clients.User(msg.To).SendAsync("SendMessage", msg);//发给哪个人
        }

        /// <summary>
        /// 演示方法
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public async Task SendMessageToMyGroup(Message msg)
        {
            OnlineClient client;
            lock (SyncObj)
            {
                OnlineClients.TryGetValue(msg.From, out client);
            }
            Console.WriteLine($"SendMessage:user{msg.From},togroup:{msg.GroupId},message{msg.Content}");
            await Clients.Group(msg.GroupId).SendAsync("SendMessage", msg);//发给本组
        }


        /// <summary>
        /// 演示方法
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public async Task SendMessageToGroups(Message msg)
        {
            OnlineClient client;
            lock (SyncObj)
            {
                OnlineClients.TryGetValue(msg.From, out client);
            }
            Console.WriteLine($"SendMessage:user{msg.From},togroups:{JsonConvert.SerializeObject(msg.ToGroupIds)},message{msg.Content}");
            foreach (var group in msg.ToGroupIds)
            {
                await Clients.Group(group).SendAsync("SendMessage", msg);//发给本组
            }
        }
    }


    public class OnlineClient
    {
        public string NickName { get; set; }
        public string Avatar { get; set; }
        public List<string> ConnectionIds { get; set; }

        public string Identifier { get; set; }

        public string GroupId { get; set; }
    }

    [Serializable]
    public class HubBaseEntity
    {
        public override string ToString()
        {
            try
            {
                return JsonConvert.SerializeObject(this);
            }
            catch
            {
                return "";
            }
        }
    }

    public class Message : HubBaseEntity
    {

        public string GroupId { get; set; }

        public string Type { get; set; }

        public string Title { get; set; }

        public string BaseUrl { get; set; }

        public string Url { get; set; }

        public string Content { get; set; }
        public string From { get; set; }

        public string To { get; set; }

        public List<string> ToGroupIds { get; set; }


        public string Callback { get; set; }
    }
}
