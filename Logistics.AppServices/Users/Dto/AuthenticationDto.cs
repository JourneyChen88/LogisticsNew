using Logistics.EF.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace Logistics.AppServices
{

    public class AuthenticationDto
    {
        /// <summary>
        /// �绰
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        [StringLength(LogisticsConsts.MaxLength64)]
        public string RealName { get; set; }

        /// <summary>
        /// ���֤��
        /// </summary>
        [StringLength(20)]
        public string IdCardNo { get; set; }


    }
}
