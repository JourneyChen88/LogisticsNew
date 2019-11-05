using Logistics.EF.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace Logistics.AppServices
{

    public class AuthenticationDto
    {
        /// <summary>
        /// 电话
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [StringLength(LogisticsConsts.MaxLength64)]
        public string RealName { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [StringLength(20)]
        public string IdCardNo { get; set; }


    }
}
