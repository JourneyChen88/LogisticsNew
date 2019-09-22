using System.Collections.Generic;
using System.Threading.Tasks;

namespace Logistics.AppServices
{
    public interface IReadAllAsync
    {
        Task<List<ReadAllOutput>> ReadAllAsync<ReadAllRequest, ReadAllOutput>(ReadAllRequest request);
        Task<List<ReadAllOutput>> ReadAllAsync<ReadAllOutput>();
    }

    public interface ICreateAsync
    {
        Task<CreateOutpput> CreateAsync<CreateInput, CreateOutpput>(CreateInput input);
    }
    public interface IGetAsync<TPrimaryKey>
    {
        Task<Output> GetAsync<Output>(TPrimaryKey id);
    }

    public interface IDeleteAsync<TPrimaryKey>
    {
        Task DeleteAsync(TPrimaryKey id);
    }
    public interface IEditAsync<TPrimaryKey>
    {
        Task<Output> EditAsync<EditInput, Output>(EditInput input) where EditInput : IdInput<TPrimaryKey>;
    }


}

