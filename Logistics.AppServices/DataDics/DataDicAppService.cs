using AgileObjects.AgileMapper;
using Logistics.EF.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.AppServices
{
    public class DataDicAppService : IDataDicAppService
    {
        private IRepository<DataDic, Guid> _Repository;

        public DataDicAppService(IRepository<DataDic, Guid> repository)
        {
            _Repository = repository;
        }
        public async Task<bool> Init()
        {
            bool res = false;
            if (_Repository.GetAll().LongCount()==0)
            {
                var dics = new DataDicCreator().initDics;
                res= _Repository.AddRange(dics);             
            }
        
            return await Task.FromResult(res);
        }
       
        public async Task<List<DataDicDto>> GetAll()
        {
            try
            {
                var list = _Repository.GetAll();
                var res = Mapper.Map(list).ToANew<List<DataDicDto>>();
                return await Task.FromResult(res);
            }
            catch (Exception e)
            {
                return null;
            }

        }
        public async Task<List<DataDicDto>> GetList( string typeCode)
        {
            try
            {
                var list = _Repository.GetAll().Where(a => a.TypeCode== typeCode);
                var res = Mapper.Map(list).ToANew<List<DataDicDto>>();
                return await Task.FromResult(res);
            }
            catch (Exception e)
            {
                return null;
            }

        }
        public async Task<List<DataDicDto>> GetPageList(int pageIndex, int pageSize)
        {
            var list = _Repository.GetPageList(pageIndex, pageSize) ;
            var res = Mapper.Map(list).ToANew<List<DataDicDto>>();
            return await Task.FromResult(res);
        }

        public async Task<DataDicDto> GetById(Guid id)
        {
            var list = _Repository.GetById(id);
            var res = Mapper.Map(list).ToANew<DataDicDto>();
            return await Task.FromResult(res);
        }


        public async Task<bool> Add(DataDicCreateInput input)
        {
            var entity = Mapper.Map(input).ToANew<DataDic>();
            var res = _Repository.Add(entity);
            return await Task.FromResult(res);
        }

        public async Task<bool> Delete(Guid id)
        {
            var list = _Repository.Delete(id);
            return await Task.FromResult(list);
        }
        public async Task<bool> Update(DataDicDto dto)
        {
            var entity = Mapper.Map(dto).ToANew<DataDic>();
            var list = _Repository.Update(entity);
            return await Task.FromResult(list);
        }
    }
}

