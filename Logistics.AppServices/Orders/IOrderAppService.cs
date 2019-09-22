using Logistics.AppServices;
using Logistics.EF.Core;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Logistics.AppServices
{
    public interface IOrderAppService: ITransientDependency

    {
        Task<List<OrderDto>> GetAll();

        Task<List<OrderDto>> GetPageList(int index,int size);

        Task<OrderDto> GetById(string id);
    }
}
