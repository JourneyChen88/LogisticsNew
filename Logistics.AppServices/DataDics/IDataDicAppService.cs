using Logistics.AppServices;
using Logistics.EF.Core;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Logistics.AppServices
{
    public interface IDataDicAppService : ITransientDependency

    {
        Task<bool> Init();
        Task<List<DataDicDto>> GetList(string typeCode);
        Task<List<DataDicDto>> GetAll();

        Task<List<DataDicDto>> GetPageList(int index, int size);

        Task<DataDicDto> GetById(Guid id);

        Task<bool> Add(DataDicCreateInput dto);

        Task<bool> Delete(Guid id);

        Task<bool> Update(DataDicDto dto);
    }
}
