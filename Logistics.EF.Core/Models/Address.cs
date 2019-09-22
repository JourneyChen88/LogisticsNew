
namespace Logistics.Models
{
    using Logistics;
    using Logistics.EF.Core;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Address : EntityBase
    {


        /// <summary>
        /// 联系人
        /// </summary>
        [StringLength(LogisticsConsts.MaxLength64)]
        public virtual String Linker { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        public virtual String LinkPhone { get; set; }

        /// <summary>
        /// 详细信息
        /// </summary>
        [StringLength(LogisticsConsts.MaxLength256)]
        public virtual String DetailInfo { get; set; }

        

        /// <summary>
        /// 是否默认地址
        /// </summary>
        public virtual Boolean IsDefault { get; set; }



    }
}
