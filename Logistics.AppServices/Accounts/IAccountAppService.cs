using Logistics.AppServices;
using Logistics.EF.Core;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Logistics.AppServices
{
    public interface IAccountAppService: ITransientDependency

    {
        Task<List<AccountDto>> GetList();
        Task<List<AccountDto>> GetAll(long userId);

        Task<List<AccountDto>> GetPageList(int index,int size);

        Task<AccountDto> GetById(Guid id);

        Task<bool> Add(AccountCreateInput dto);

        Task<bool> Delete(Guid id);

        Task<bool> Update(AccountDto dto);
    }
}
