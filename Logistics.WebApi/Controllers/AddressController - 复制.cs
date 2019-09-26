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
    public class AccountController : ControllerBase
    {
        private readonly IAccountAppService _appservice;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="appservice"></param>
        public AccountController(IAccountAppService appservice)
        {
            _appservice = appservice;
        }
        /// <summary>
        /// 获取所有
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<AjaxResponse<List<AccountDto>>> GetAll()
        {
            var res = await _appservice.GetAll();
            return new AjaxResponse<List<AccountDto>>(res);
        }
        /// <summary>
        /// 获取分页
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<AjaxResponse<List<AccountDto>>> GetPageList(int index, int size)
        {
            var res = await _appservice.GetPageList(index, size);
            return new AjaxResponse<List<AccountDto>>(res);
        }
        /// <summary>
        /// 获取单个
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<AjaxResponse<AccountDto>> GetById(Guid id)
        {
            var res = await _appservice.GetById(id);
            return new AjaxResponse<AccountDto>(res);
        }
        /// <summary>
        /// 增加
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<AjaxResponse<bool>> Add([FromBody]AccountCreateInput dto)
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
        public async Task<AjaxResponse<bool>> Update([FromBody]AccountDto dto)
        {
            var res = await _appservice.Update(dto);
            return new AjaxResponse<bool>(res);
        }
    }
}
