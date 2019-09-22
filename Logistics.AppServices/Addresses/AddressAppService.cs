using AgileObjects.AgileMapper;
using Logistics.AppServices;
using Logistics.EF.Core;
using Logistics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.AppServices
{
    public class AddressAppService : IAddressAppService
    {
        private IRepository<Address> _Repository;

        public AddressAppService(IRepository<Address> repository)
        {
            _Repository = repository;
        }

        public async Task<List<AddressDto>> GetAll()
        {
            try
            {
                var list = _Repository.GetAll();
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

        public async Task<AddressDto> Add(AddressCreateInput input)
        {
            var entity = Mapper.Map(input).ToANew<Address>();
            var list = _Repository.Add(entity);
            var dto = Mapper.Map(entity).ToANew<AddressDto>();
            return await Task.FromResult(dto);
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

