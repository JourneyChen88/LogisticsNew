
namespace Logistics.EF.Core
{
    using Logistics;
    using Logistics.EF.Core;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// 用户
    /// </summary>
    public class User : EntityBase<long>
    {
        /// <summary>
        /// 电话
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [StringLength(LogisticsConsts.MaxLength64)]
        public string Name { get; set; }

        public string PassWord { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [StringLength(LogisticsConsts.MaxLength1024)]
        public virtual String Remark { get; set; }

    }
}
