using Logistics.AppServices;
using Logistics.EF.Core;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Logistics.AppServices
{
    public interface IUserAppService: ITransientDependency

    {
        Task<List<UserDto>> GetAll();

        Task<List<UserDto>> GetPageList(int index,int size);

        Task<UserDto> LoginByPwd(string name, string pwd);
        Task<UserDto> Register(RegisterDto dtos);
        Task<UserDto> Authentication(AuthenticationDto dtos);
        
    }
}
