﻿using AgileObjects.AgileMapper;
using Logistics.AppServices;
using Logistics.EF.Core;
using Logistics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.AppServices
{
    public class UserAppService : IUserAppService
    {
        private IRepository<User> _Repository;

        public UserAppService(IRepository<User> userRepository)
        {
            _Repository = userRepository;
        }

        public async Task<List<UserDto>> GetAll()
        {
            try
            {
                var list = _Repository.GetAll();
                var res = Mapper.Map(list).ToANew<List<UserDto>>();
                return await Task.FromResult(res);
            }
            catch (Exception e)
            {
                return null;
            }
            
        }

        public async Task<List<UserDto>> GetPageList(int pageIndex, int pageSize)
        {
            var list = _Repository.GetPageList(pageIndex, pageSize);
            var res = Mapper.Map(list).ToANew<List<UserDto>>();
            return await Task.FromResult(res);
        }
        public async Task<UserDto> LoginByPwd(string phone, string pwd)
        {
            var entity = _Repository.GetAll().FirstOrDefault(a => a.Phone == phone && a.PassWord == pwd);
            var res = Mapper.Map(entity).ToANew<UserDto>();
            return await Task.FromResult(res);
        }
        public async Task<UserDto> Register(RegisterDto dtos)
        {
            var entity = Mapper.Map(dtos).ToANew<User>();
            var res = _Repository.Add(entity);
            if (res)
            {
                var dto = Mapper.Map(entity).ToANew<UserDto>();
                return await Task.FromResult(dto);
            }
            else
            {
                return null;
            }
         
        }
    }
}
