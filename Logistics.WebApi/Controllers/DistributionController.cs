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
    public class DistributionController : ControllerBase
    {
        private readonly IDistributionAppService _appservice;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="appservice"></param>
        public DistributionController(IDistributionAppService appservice)
        {
            _appservice = appservice;
        }
        /// <summary>
        /// 获取所有
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<AjaxResponse<List<DistributionDto>>> GetAll()
        {
            var res = await _appservice.GetAll();
            return new AjaxResponse<List<DistributionDto>>(res);
        }


        /// <summary>
        /// 获取分页
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<AjaxResponse<List<DistributionDto>>> GetPageList(int index)
        {
            var res = await _appservice.GetPageList(index, 8);
            return new AjaxResponse<List<DistributionDto>>(res);
        }

        /// <summary>
        /// 根据接单人获取分页
        /// </summary>
        /// <param name="deliver">接单人</param>
        /// <param name="index">分页序号</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<AjaxResponse<List<DistributionHisDto>>> GetByDeliver(long deliver, int index)
        {
            var res = await _appservice.GetByDeliver(deliver, index, 8);
            return new AjaxResponse<List<DistributionHisDto>>(res);
        }
        /// <summary>
        /// 增加
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<AjaxResponse<bool>> Add([FromBody]DistributionCreateInput dto)
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
        public async Task<AjaxResponse<bool>> Update([FromBody]DistributionDto dto)
        {
            var res = await _appservice.Update(dto);
            return new AjaxResponse<bool>(res);
        }
    }
}
