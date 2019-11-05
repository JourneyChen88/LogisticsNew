using Logistics.EF.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Logistics.AppServices
{

    public class DistributionCreateInput
    {

        /// <summary>
        /// 订单编号
        /// </summary>
        public  Guid OrderId { get; set; }

        /// <summary>
        /// 配送人
        /// </summary>
        public  long Deliver { get; set; }

        /// <summary>
        /// 签收人
        /// </summary>
        public  String Signer { get; set; }

        /// <summary>
        /// 签收时间
        /// </summary>
        public  DateTime? SignTime { get; set; }

    }
}
