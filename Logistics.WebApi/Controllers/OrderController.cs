using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Logistics.AppServices;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Mvc;

namespace Logistics.WebApi.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderAppService _appservice;
        private readonly IHostingEnvironment _hostingEnvironment;

        public OrderController(IOrderAppService appservice, IHostingEnvironment hostingEnvironment)
        {
            _appservice = appservice;
            _hostingEnvironment = hostingEnvironment;
        }
        /// <summary>
        /// 获取所有
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<AjaxResponse<List<OrderDto>>> GetAll()
        {
            var res = await _appservice.GetAll();
            return new AjaxResponse<List<OrderDto>>(res);
        }


        /// <summary>
        /// 获取分页
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<AjaxResponse<List<OrderDto>>> GetPageList(int index)
        {
            var res = await _appservice.GetPageList(index, 8);
            return new AjaxResponse<List<OrderDto>>(res);
        }
        /// <summary>
        /// 根据发单人获取分页
        /// </summary>
        /// <param name="orderUser">发单人</param>
        /// <param name="index">分页序号</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<AjaxResponse<List<OrderHisDto>>> GetBySender(long sender, int index)
        {
            var res = await _appservice.GetBySender(sender, index, 8);
            return new AjaxResponse<List<OrderHisDto>>(res);
        }

      
        ///// <summary>
        ///// 获取单个
        ///// </summary>
        ///// <returns></returns>
        //[HttpGet]
        //public async Task<AjaxResponse<OrderDto>> GetById(Guid id)
        //{
        //    var res = await _appservice.GetById(id);
        //    return new AjaxResponse<OrderDto>(res);
        //}
        /// <summary>
        /// 增加
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<AjaxResponse<bool>> Add([FromBody]OrderCreateInput dto)
        {
            var res = await _appservice.Add(dto);
            return new AjaxResponse<bool>(res);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<AjaxResponse<bool>> Delete([FromBody] Guid id)
        {
            var res = await _appservice.Delete(id);
            return new AjaxResponse<bool>(res);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<AjaxResponse<bool>> Update([FromBody]OrderDto dto)
        {
            var res = await _appservice.Update(dto);
            return new AjaxResponse<bool>(res);
        }
        [HttpPost]
        public async Task<bool> AddPic([FromForm] IFormCollection formCollection)
        {
            bool result = false;
            string webRootPath = _hostingEnvironment.WebRootPath;
            string contentRootPath = _hostingEnvironment.ContentRootPath;

            FormFileCollection filelist = (FormFileCollection)formCollection.Files;

            foreach (IFormFile file in filelist)
            {
                String Tpath = "/Order/";
                string FileName = file.FileName;
                string FilePath = contentRootPath + Tpath;

                DirectoryInfo di = new DirectoryInfo(FilePath);


                if (!di.Exists) { di.Create(); }

                using (FileStream fs = System.IO.File.Create(FilePath + FileName))
                {
                    // 复制文件
                    file.CopyTo(fs);
                    // 清空缓冲区数据
                    fs.Flush();
                }
                result = true;
            }
            return result;
        }
    }
}
