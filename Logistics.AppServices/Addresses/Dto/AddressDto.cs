using Logistics.EF.Core;
using Logistics.EF.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace Logistics.AppServices
{

    public class AddressDto : EntityDtoBase
    {
        public  long UserId { get; set; }
        /// <summary>
        /// 联系人
        /// </summary>
        [StringLength(LogisticsConsts.MaxLength64)]
        public  String Linker { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        public  String LinkPhone { get; set; }

        /// <summary>
        /// 区域（省市县）
        /// </summary>
        public virtual String Location { get; set; }

        /// <summary>
        /// 详细地址
        /// </summary>
        [StringLength(LogisticsConsts.MaxLength256)]
        public virtual String Detail { get; set; }



        /// <summary>
        /// 是否默认地址
        /// </summary>
        public  Boolean IsDefault { get; set; }

    }
}
