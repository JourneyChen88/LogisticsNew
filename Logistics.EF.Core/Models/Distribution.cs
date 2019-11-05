using Logistics.EF.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace Logistics.EF.Core
{
    /// <summary>
    /// 配送单
    /// </summary>
    public class Distribution : EntityBase
    {
        /// <summary>
        /// 订单编号
        /// </summary>
        public virtual Guid OrderId { get; set; }

        /// <summary>
        /// 配送人
        /// </summary>
        public virtual long Deliver { get; set; }

        /// <summary>
        /// 签收人
        /// </summary>
        public virtual String Signer { get; set; }

        /// <summary>
        /// 签收时间
        /// </summary>
        public virtual DateTime? SignTime { get; set; }
    }
}
