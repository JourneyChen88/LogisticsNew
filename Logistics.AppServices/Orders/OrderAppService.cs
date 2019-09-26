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
    public class OrderAppService : IOrderAppService
    {
        private IRepository<Order, Guid> _Repository;

        public OrderAppService(IRepository<Order, Guid> repository)
        {
            _Repository = repository;
        }

        public async Task<List<OrderDto>> GetAll()
        {
            try
            {
                var list = _Repository.GetAll();
                var res = Mapper.Map(list).ToANew<List<OrderDto>>();
                return await Task.FromResult(res);
            }
            catch (Exception e)
            {
                return null;
            }
            
        }

        public async Task<List<OrderDto>> GetPageList(int pageIndex, int pageSize)
        {
            var list = _Repository.GetPageList(pageIndex, pageSize);
            var res = Mapper.Map(list).ToANew<List<OrderDto>>();
            return await Task.FromResult(res);
        }

        public async Task<OrderDto> GetById(string id)
        {
            var list = _Repository.GetById(id );
            var res = Mapper.Map(list).ToANew<OrderDto>();
            return await Task.FromResult(res);
        }
    }
}

