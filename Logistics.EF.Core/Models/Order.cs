using Logistics.EF.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Logistics.Models
{
    public class Order : EntityBase
    {
        /// <summary>
        /// 订单发起人
        /// </summary>
        public virtual Guid OrderUser { get; set; }

        /// <summary>
        /// 发单价
        /// </summary>
        public virtual decimal Price { get; set; }

        /// <summary>
        /// 配送人
        /// </summary>
        public virtual Guid? DeliverUser { get; set; }
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
        /// 目的地
        /// </summary>
        public virtual string Dstination { get; set; }

        /// <summary>
        /// 目的地经度
        /// </summary>
        public virtual float DestLng { get; set; }

        /// <summary>
        /// 目的地纬度
        /// </summary>
        public virtual float DestLat { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public virtual int Qty { get; set; }



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
            OrderStatus = 1;
        }
    }
}
