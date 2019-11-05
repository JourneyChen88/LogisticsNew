using AgileObjects.AgileMapper;
using Logistics.EF.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.AppServices
{
    public class DistributionAppService : IDistributionAppService
    {
        private IRepository<Distribution, Guid> _Repository;

        private IRepository<Order, Guid> _orderRepository;
        private IRepository<DataDic, Guid> _datadicRepository;
        private IRepository<User, long> _userRepository;
        private readonly LogisticsDbContext _context = null;

        public DistributionAppService(IRepository<Distribution, Guid> repository,
                                            IRepository<DataDic, Guid> datadicRepository,
                                            IRepository<Order, Guid> orderRepository,
                                            IRepository<User, long> userRepository,
                                            LogisticsDbContext context)
        {
            _context = context;
            _orderRepository = orderRepository;
            _userRepository = userRepository;
            _datadicRepository = datadicRepository;
            _Repository = repository;
        }

        public async Task<List<DistributionDto>> GetAll()
        {
            try
            {
                var list = _Repository.GetAll();
                var res = Mapper.Map(list).ToANew<List<DistributionDto>>();
                return await Task.FromResult(res);
            }
            catch (Exception e)
            {
                return null;
            }

        }

        public async Task<List<DistributionDto>> GetPageList(int pageIndex, int pageSize)
        {
            var list = _Repository.GetPageList(pageIndex, pageSize);
            var res = Mapper.Map(list).ToANew<List<DistributionDto>>();
            return await Task.FromResult(res);
        }

        public async Task<List<DistributionHisDto>> GetByDeliver(long deliver, int index, int size)
        {
            var list = _Repository.GetPageList(index, size).Where(a => a.Deliver == deliver);
            var res = (from l in list
                       join u in _userRepository.GetAll() on l.Deliver equals u.Id
                       join o in _orderRepository.GetAll() on l.OrderId equals o.Id
                       join su in _userRepository.GetAll() on o.Sender equals su.Id
                       join d in _datadicRepository.GetAll().Where(a => a.TypeCode == "OrderStatus") on o.OrderStatus equals d.ItemCode

                       select new DistributionHisDto
                       {
                           OrderNo = o.OrderNo,
                           SenderName = su.RealName,
                           SenderPhone = su.Phone,
                           DeadLine = o.DeadLine,
                           DeliverName = u.RealName,
                           DeliverPhone = u.Phone,
                           DestLat = o.DestLat,
                           DestLng = o.DestLng,
                           Destination = o.Destination,
                           MailingAddress = o.MailingAddress,
                           MailingLat = o.MailingLat,
                           MailingLng = o.MailingLng,
                           OrderStatus = o.OrderStatus,
                           Price = o.Price,
                           PicPath1 = o.PicPath1,
                           PicPath2 = o.PicPath2,
                           PicPath3 = o.PicPath3,
                           PicPath4 = o.PicPath4,
                           Receiver = o.Receiver,
                           ReceiverPhone = o.ReceiverPhone,
                           StatusInfo=d.ItemName,
                           StatusDetail = o.OrderStatus == 1 ? "收件人：【" + o.Receiver + "】" + o.ReceiverPhone :
                          "签收人：" + l.Signer + "签收时间：" + l.SignTime.Value.ToString("yyyy-MM-dd HH:mm")

                       }).ToList();

            return await Task.FromResult(res);
        }

        public async Task<DistributionDto> GetById(string id)
        {
            var list = _Repository.GetById(id);
            var res = Mapper.Map(list).ToANew<DistributionDto>();
            return await Task.FromResult(res);
        }
        public async Task<bool> Add(DistributionCreateInput input)
        {
            bool respose = false;
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    //增加配送单
                    var entity = Mapper.Map(input).ToANew<Distribution>();
                    var res = _context.Distributions.Add(entity);

                    //修改订单状态
                    var order = _orderRepository.GetById(input.OrderId);
                    order.OrderStatus = 2;
                    _context.Orders.Update(order);

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
        public async Task<bool> Update(DistributionDto dto)
        {
            var entity = Mapper.Map(dto).ToANew<Distribution>();
            var list = _Repository.Update(entity);
            return await Task.FromResult(list);
        }
    }
}

