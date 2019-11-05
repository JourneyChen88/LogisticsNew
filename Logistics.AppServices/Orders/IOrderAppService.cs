using Logistics.AppServices;
using Logistics.EF.Core;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Logistics.AppServices
{
    public interface IOrderAppService: ITransientDependency

    {
        Task<List<OrderDto>> GetAll();

        Task<List<OrderDto>> GetPageList(int index,int size);

        Task<List<OrderHisDto>> GetBySender(long orderUser,int index, int size);

       
        

        Task<OrderDto> GetById(string id);

        Task<bool> Add(OrderCreateInput dto);

        Task<bool> Delete(Guid id);

        Task<bool> Update(OrderDto dto);

    }
}
