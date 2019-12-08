using Logistics.AppServices;
using Logistics.EF.Core;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Logistics.AppServices
{
    public interface IEvaluateAppService : ITransientDependency

    {
        Task<List<EvaluateDto>> GetAll();

        Task<List<EvaluateDto>> GetPageList(int index, int size);

        Task<EvaluateDto> GetById(Guid id);

        Task<bool> Add(EvaluateCreateInput dto);

        Task<bool> Delete(Guid id);

        Task<bool> Update(EvaluateDto dto);
    }
}
