using Logistics.EF.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Logistics.EF.Core
{
    public class Order : EntityBase
    {
        /// <summary>
        /// 
        /// </summary>
        public virtual string OrderNo { get; set; }
        /// <summary>
        /// 寄件人
        /// </summary>
        public virtual long Sender { get; set; }

        /// <summary>
        /// 发单价
        /// </summary>
        public virtual decimal Price { get; set; }

      
        /// <summary>
        /// 发件地址
        /// </summary>
        [StringLength(LogisticsConsts.MaxLength64)]
        public virtual string MailingAddress { get; set; }

        /// <summary>
        /// 发件经度
        /// </summary>
        public virtual float MailingLng { get; set; }
        /// <summary>
        /// 发件纬度
        /// </summary>
        public virtual float MailingLat { get; set; }

        /// <summary>
        /// 收件人
        /// </summary>
        public virtual string Receiver { get; set; }

        /// <summary>
        /// 收件人电话
        /// </summary>
        public virtual string ReceiverPhone { get; set; }

        /// <summary>
        /// 目的地
        /// </summary>
        public virtual string Destination { get; set; }

        /// <summary>
        /// 目的地经度
        /// </summary>
        public virtual float DestLng { get; set; }

        /// <summary>
        /// 目的地纬度
        /// </summary>
        public virtual float DestLat { get; set; }

        public virtual String PicPath1 { get; set; }

        public virtual String PicPath2 { get; set; }
        public virtual String PicPath3 { get; set; }
        public virtual String PicPath4 { get; set; }

        /// <summary>
        /// 最迟送到时间
        /// </summary>
        public virtual DateTime? DeadLine { get; set; }



        /// <summary>
        /// 订单状态
        /// </summary>
        public virtual int OrderStatus { get; set; }



        /// <summary>
        /// 备注
        /// </summary>
        [StringLength(LogisticsConsts.MaxLength256)]
        public virtual String Remark { get; set; }

        public Order()
        {
            OrderStatus = (int)OrderStatusEnum.NotSet;//默认设置未接单
        }
    }
}
