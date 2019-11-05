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
    public class UserController : ControllerBase
    {
        private readonly IUserAppService _appservice;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="appservice"></param>
        public UserController(IUserAppService appservice)
        {
            _appservice = appservice;
        }
        /// <summary>
        /// 获取所有用户
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<AjaxResponse<List<UserDto>>> GetAll()
        {
            var res = await _appservice.GetAll();
            return new AjaxResponse<List<UserDto>>(res);
        }
        /// <summary>
        /// 获取分页用户
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<AjaxResponse<List<UserDto>>> GetPageList(int index, int size)
        {
            var res = await _appservice.GetPageList(index, size);
            return new AjaxResponse<List<UserDto>>(res);
        }
        /// <summary>
        /// 手机密码登录
        /// </summary>
        /// <param name="phone"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<AjaxResponse<UserDto>> LoginByPwd([FromBody]LoginInput input)
        {
            var res = await _appservice.LoginByPwd(input.Phone, input.PassWord);
            return new AjaxResponse<UserDto>(res);
        }

        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<AjaxResponse<UserDto>>  Register([FromBody]RegisterDto dtos)
        {
            var res = await _appservice.Register(dtos);
            return new AjaxResponse<UserDto>(res);
        }

        /// <summary>
        /// 实名认证
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<AjaxResponse<UserDto>> Authentication([FromBody]AuthenticationDto dtos)
        {
            var res = await _appservice.Authentication(dtos);
            return new AjaxResponse<UserDto>(res);
        }
       
    }
}
