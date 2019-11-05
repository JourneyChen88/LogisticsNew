using Logistics.EF.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace Logistics.AppServices
{

    public class OrderDto : EntityDtoBase
    {

        public virtual string OrderNo { get; set; }
        /// <summary>
        /// 寄件人
        /// </summary>
        public  long Sender { get; set; }

        /// <summary>
        /// 发单价
        /// </summary>
        public  decimal Price { get; set; }

      
        /// <summary>
        /// 发件地址
        /// </summary>
        [StringLength(LogisticsConsts.MaxLength64)]
        public  string MailingAddress { get; set; }

        /// <summary>
        /// 发件经度
        /// </summary>
        public  float MailingLng { get; set; }
        /// <summary>
        /// 发件纬度
        /// </summary>
        public  float MailingLat { get; set; }

        /// <summary>
        /// 收件人
        /// </summary>
        public  string Receiver { get; set; }

        /// <summary>
        /// 收件人电话
        /// </summary>
        public  string ReceiverPhone { get; set; }

        /// <summary>
        /// 目的地
        /// </summary>
        public  string Destination { get; set; }

        /// <summary>
        /// 目的地经度
        /// </summary>
        public  float DestLng { get; set; }

        /// <summary>
        /// 目的地纬度
        /// </summary>
        public  float DestLat { get; set; }
        /// <summary>
        /// 图片路径
        /// </summary>
        public String PicPath1 { get; set; }

        public String PicPath2 { get; set; }
        public String PicPath3 { get; set; }
        public String PicPath4 { get; set; }


        /// <summary>
        /// 最迟送到时间
        /// </summary>
        public  DateTime? DeadLine { get; set; }



        /// <summary>
        /// 订单状态
        /// </summary>
        public  int OrderStatus { get; set; }



        /// <summary>
        /// 备注
        /// </summary>
        [StringLength(LogisticsConsts.MaxLength256)]
        public  String Remark { get; set; }

    }
}
