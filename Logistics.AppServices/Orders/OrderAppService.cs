using AgileObjects.AgileMapper;
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
        private IRepository<DataDic, Guid> _datadicRepository;
        private IRepository<User, long> _userRepository;
        private readonly LogisticsDbContext _context = null;

        public OrderAppService(IRepository<Order, Guid> repository,
                                            IRepository<DataDic, Guid> datadicRepository,
                                            IRepository<User, long> userRepository,
                                            LogisticsDbContext context)
        {
            _context = context;
            _userRepository = userRepository;
            _datadicRepository = datadicRepository;
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
        public async Task<List<OrderHisDto>> GetBySender(long sender, int index, int size)
        {
            var list = _Repository.GetPageList(index, size).Where(a => a.Sender == sender);
            var data = _datadicRepository.GetAll().Where(a => a.TypeCode == "OrderStatus");
            var user = _userRepository.GetAll();
            var res = (from l in list
                       join u in user on l.Sender equals u.Id
                       join d in data on l.OrderStatus equals d.ItemCode
                       select new OrderHisDto
                       {
                           OrderNo = l.OrderNo,
                           SenderName = u.RealName,
                           SenderPhone = u.Phone,
                           DeadLine = l.DeadLine,
                           DestLat = l.DestLat,
                           DestLng = l.DestLng,
                           Destination = l.Destination,
                           MailingAddress = l.MailingAddress,
                           MailingLat = l.MailingLat,
                           MailingLng = l.MailingLng,
                           OrderStatus = l.OrderStatus,
                           Price = l.Price,
                           PicPath1 = l.PicPath1,
                           PicPath2 = l.PicPath2,
                           PicPath3 = l.PicPath3,
                           PicPath4 = l.PicPath4,
                           Receiver = l.Receiver,
                           ReceiverPhone = l.ReceiverPhone,
                           Remark = l.Remark,
                           StatusInfo = d.ItemName


                       }).ToList();

            return await Task.FromResult(res);
        }
       
        public async Task<OrderDto> GetById(string id)
        {
            var list = _Repository.GetById(id);
            var res = Mapper.Map(list).ToANew<OrderDto>();
            return await Task.FromResult(res);
        }
        public async Task<bool> Add(OrderCreateInput input)
        {
            bool respose = false;
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var count = _Repository.GetAll().Where(a => a.CreationTime.ToString("yyyyMMdd")
                    == DateTime.Now.ToString("yyyyMMdd")).Count();

                    var entity = Mapper.Map(input).ToANew<Order>();
                    entity.OrderNo = DateTime.Now.ToString("yyyyMMdd") + string.Format("{0:D6}", count + 1);

                    var res = _context.Orders.Add(entity);
                    //foreach (var item in input.DetailList)
                    //{

                    //    var detail = Mapper.Map(item).ToANew<OrderDetail>();
                    //    detail.Id = res.Entity.Id;
                    //    _context.OrderDetails.Add(detail);
                    //}

                    transaction.Commit();
                    respose = _context.SaveChanges() > 0 ? true : false;
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    respose = false;
                }


            }


            return await Task.FromResult(respose);
        }

        public async Task<bool> Delete(Guid id)
        {

            var list = _Repository.Delete(id);
            return await Task.FromResult(list);
        }
        public async Task<bool> Update(OrderDto dto)
        {
            var entity = Mapper.Map(dto).ToANew<Order>();
            var list = _Repository.Update(entity);
            return await Task.FromResult(list);
        }

        //public async Task<bool> AddPic(Guid id)
        //{

        //    var list = _Repository.Delete(id);
        //    return await Task.FromResult(list);
        //}
    }
}

