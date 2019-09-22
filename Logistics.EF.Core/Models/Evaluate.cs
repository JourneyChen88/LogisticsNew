
namespace Logistics.Models
{
    using Logistics;
    using Logistics.EF.Core;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// 评价
    /// </summary>
    public class Evaluate : EntityBase
    {
        /// <summary>
        /// 订单ID
        /// </summary>
        public virtual Guid OrderID { get; set; }

        /// <summary>
        /// 评分
        /// </summary>
        public virtual int Score { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [StringLength(LogisticsConsts.MaxLength2048)]
        public virtual String Remark { get; set; }

    }
}
