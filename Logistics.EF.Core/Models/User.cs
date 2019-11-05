
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
        /// 用户名
        /// </summary>
        [StringLength(LogisticsConsts.MaxLength64)]
        public string UserName { get; set; }

        public string PassWord { get; set; }


        /// <summary>
        /// 真实名称
        /// </summary>
        [StringLength(LogisticsConsts.MaxLength64)]
        public string RealName { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [StringLength(20)]
        public string IdCardNo { get; set; }

        /// <summary>
        /// 是否实名认证
        /// </summary>
        public bool IsAuthentication { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [StringLength(LogisticsConsts.MaxLength1024)]
        public virtual String Remark { get; set; }

    }
}
