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
        public async Task<ActionResult<List<UserDto>>> GetAll()
        {
            var res = await _appservice.GetAll();
            return new ActionResult<List<UserDto>>(res);
        }
        /// <summary>
        /// 获取分页用户
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<List<UserDto>>> GetPageList(int index, int size)
        {
            var res = await _appservice.GetPageList(index, size);
            return new ActionResult<List<UserDto>>(res);
        }
        /// <summary>
        /// 手机密码登录
        /// </summary>
        /// <param name="phone"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<UserDto>> LoginByPwd([FromBody]LoginInput input)
        {
            var res = await _appservice.LoginByPwd(input.Phone, input.PassWord);
            return new ActionResult<UserDto>(res);
        }
        [HttpPost]
        public async Task<ActionResult<UserDto>>  Register([FromBody]RegisterDto dtos)
        {
            var res = await _appservice.Register(dtos);
            return new ActionResult<UserDto>(res);
        }
       
    }
}
