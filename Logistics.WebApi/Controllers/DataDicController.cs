using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logistics.AppServices;
using Microsoft.AspNetCore.Mvc;

namespace Logistics.WebApi.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class DataDicController : ControllerBase
    {
        private readonly IDataDicAppService _appservice;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="appservice"></param>
        public DataDicController(IDataDicAppService appservice)
        {
            _appservice = appservice;
        }
        /// <summary>
        /// 初始化
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<AjaxResponse<bool>> Init()
        {
            var res = await _appservice.Init();
            return new AjaxResponse<bool>(res);
        }

        /// <summary>
        /// 获取所有
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<AjaxResponse<List<DataDicDto>>> GetAll()
        {
            var res = await _appservice.GetAll();
            return new AjaxResponse<List<DataDicDto>>(res);
        }

        [HttpGet]
        public async Task<AjaxResponse<List<DataDicDto>>> GetList(string typeCode)
        {
            var res = await _appservice.GetList(typeCode);
            return new AjaxResponse<List<DataDicDto>>(res);
        }
        /// <summary>
        /// 获取分页
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<AjaxResponse<List<DataDicDto>>> GetPageList(int index, int size)
        {
            var res = await _appservice.GetPageList(index, size);
            return new AjaxResponse<List<DataDicDto>>(res);
        }
        /// <summary>
        /// 获取单个
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<AjaxResponse<DataDicDto>> GetById(Guid id)
        {
            var res = await _appservice.GetById(id);
            return new AjaxResponse<DataDicDto>(res);
        }
        /// <summary>
        /// 增加
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<AjaxResponse<bool>> Add([FromBody]DataDicCreateInput dto)
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
        public async Task<AjaxResponse<bool>> Update([FromBody]DataDicDto dto)
        {
            var res = await _appservice.Update(dto);
            return new AjaxResponse<bool>(res);
        }
    }
}
