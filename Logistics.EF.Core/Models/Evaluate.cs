
namespace Logistics.Models
{
    using Logistics;
    using Logistics.EF.Core;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// ����
    /// </summary>
    public class Evaluate : EntityBase
    {
        /// <summary>
        /// ����ID
        /// </summary>
        public virtual Guid OrderID { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public virtual int Score { get; set; }
        /// <summary>
        /// ��ע
        /// </summary>
        [StringLength(LogisticsConsts.MaxLength2048)]
        public virtual String Remark { get; set; }

    }
}
