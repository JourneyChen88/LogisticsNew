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
    public class AddressController : ControllerBase
    {
        private readonly IAddressAppService _appservice;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="appservice"></param>
        public AddressController(IAddressAppService appservice)
        {
            _appservice = appservice;
        }
        /// <summary>
        /// 获取所有
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<AjaxResponse<List<AddressDto>>> GetAll(long userId)
        {
            var res = await _appservice.GetAll(userId);
            return new AjaxResponse<List<AddressDto>>(res);
        }
        /// <summary>
        /// 获取分页
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<AjaxResponse<List<AddressDto>>> GetPageList(int index, int size)
        {
            var res = await _appservice.GetPageList(index, size);
            return new AjaxResponse<List<AddressDto>>(res);
        }
        /// <summary>
        /// 获取单个
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<AjaxResponse<AddressDto>> GetById(Guid id)
        {
            var res = await _appservice.GetById(id);
            return new AjaxResponse<AddressDto>(res);
        }
        /// <summary>
        /// 增加
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<AjaxResponse<bool>> Add([FromBody]AddressCreateInput dto)
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
        public async Task<AjaxResponse<bool>> Update([FromBody]AddressDto dto)
        {
            var res = await _appservice.Update(dto);
            return new AjaxResponse<bool>(res);
        }
    }
}
