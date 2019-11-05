using AgileObjects.AgileMapper;
using Logistics.AppServices;
using Logistics.EF.Core;
using Logistics.EF.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.AppServices
{
    public class AddressAppService : IAddressAppService
    {
        private IRepository<Address,Guid> _Repository;

        public AddressAppService(IRepository<Address, Guid> repository)
        {
            _Repository = repository;
        }

        public async Task<List<AddressDto>> GetAll(long userId)
        {
            try
            {
                var list = _Repository.GetAll().Where(a=>a.UserId==userId);
                var res = Mapper.Map(list).ToANew<List<AddressDto>>();
                return await Task.FromResult(res);
            }
            catch (Exception e)
            {
                return null;
            }
            
        }

        public async Task<List<AddressDto>> GetPageList(int pageIndex, int pageSize)
        {
            var list = _Repository.GetPageList(pageIndex, pageSize);
            var res = Mapper.Map(list).ToANew<List<AddressDto>>();
            return await Task.FromResult(res);
        }

        public async Task<AddressDto> GetById(Guid id)
        {
            var list = _Repository.GetById(id );
            var res = Mapper.Map(list).ToANew<AddressDto>();
            return await Task.FromResult(res);
        }

        public async Task<bool> Add(AddressCreateInput input)
        {
            var entity = Mapper.Map(input).ToANew<Address>();
            var res = _Repository.Add(entity);
            return await Task.FromResult(res);
        }

        public async Task<bool>  Delete(Guid id)
        {
         
            var list = _Repository.Delete(id);
            return await Task.FromResult(list);
        }
        public async Task<bool> Update(AddressDto dto)
        {
            var entity = Mapper.Map(dto).ToANew<Address>();
            var list = _Repository.Update(entity);
            return await Task.FromResult(list);
        }

    }
}

