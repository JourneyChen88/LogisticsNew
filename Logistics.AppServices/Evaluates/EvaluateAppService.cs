using AgileObjects.AgileMapper;
using Logistics.EF.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.AppServices
{
    public class EvaluateAppService : IEvaluateAppService
    {
        private IRepository<Evaluate, Guid> _Repository;

        public EvaluateAppService(IRepository<Evaluate, Guid> repository)
        {
            _Repository = repository;
        }
  
       
        public async Task<List<EvaluateDto>> GetAll()
        {
            try
            {
                var list = _Repository.GetAll();
                var res = Mapper.Map(list).ToANew<List<EvaluateDto>>();
                return await Task.FromResult(res);
            }
            catch (Exception e)
            {
                return null;
            }

        }
   
        public async Task<List<EvaluateDto>> GetPageList(int pageIndex, int pageSize)
        {
            var list = _Repository.GetPageList(pageIndex, pageSize) ;
            var res = Mapper.Map(list).ToANew<List<EvaluateDto>>();
            return await Task.FromResult(res);
        }

        public async Task<EvaluateDto> GetById(Guid id)
        {
            var list = _Repository.GetById(id);
            var res = Mapper.Map(list).ToANew<EvaluateDto>();
            return await Task.FromResult(res);
        }


        public async Task<bool> Add(EvaluateCreateInput input)
        {
            var entity = Mapper.Map(input).ToANew<Evaluate>();
            var res = _Repository.Add(entity);
            return await Task.FromResult(res);
        }

        public async Task<bool> Delete(Guid id)
        {
            var list = _Repository.Delete(id);
            return await Task.FromResult(list);
        }
        public async Task<bool> Update(EvaluateDto dto)
        {
            var entity = Mapper.Map(dto).ToANew<Evaluate>();
            var list = _Repository.Update(entity);
            return await Task.FromResult(list);
        }
    }
}

