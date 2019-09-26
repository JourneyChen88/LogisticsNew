
namespace Logistics.EF.Core
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// 支付
    /// </summary>
    public class Pay : EntityBase
    {


        /// <summary>
        /// 订单ID
        /// </summary>      
        public virtual Guid OrderId { get; set; }
        /// <summary>
        /// 支付方式
        /// </summary>
        public virtual int PayMethod { get; set; }
        /// <summary>
        /// 支付账号
        /// </summary>      
        public virtual String PayAccount { get; set; }
        /// <summary>
        /// 支付金额
        /// </summary>
        public virtual decimal PayAmount { get; set; }
        /// <summary>
        /// 支付状态
        /// </summary>
        public virtual int PayStatus { get; set; }



    }
}
