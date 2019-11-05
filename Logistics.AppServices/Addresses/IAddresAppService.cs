using Logistics.AppServices;
using Logistics.EF.Core;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Logistics.AppServices
{
    public interface IAddressAppService : ITransientDependency
    {
        Task<List<AddressDto>> GetAll(long userId);

        Task<List<AddressDto>> GetPageList(int index, int size);
        Task<AddressDto> GetById(Guid id);
        Task<bool> Add(AddressCreateInput dto);

        Task<bool> Delete(Guid id);

        Task<bool> Update(AddressDto dto);

    }
}
