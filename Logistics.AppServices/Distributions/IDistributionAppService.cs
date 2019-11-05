using Logistics.AppServices;
using Logistics.EF.Core;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Logistics.AppServices
{
    public interface IDistributionAppService: ITransientDependency

    {
        Task<List<DistributionDto>> GetAll();

        Task<List<DistributionDto>> GetPageList(int index,int size);


        Task<List<DistributionHisDto>> GetByDeliver(long deliver, int index, int size);
        

        Task<DistributionDto> GetById(string id);

        Task<bool> Add(DistributionCreateInput dto);

        Task<bool> Delete(Guid id);

        Task<bool> Update(DistributionDto dto);

    }
}
