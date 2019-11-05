using Logistics.EF.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace Logistics.AppServices
{

    public class RegisterDto
    {
        /// <summary>
        /// �绰
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        [StringLength(LogisticsConsts.MaxLength64)]
        public string UserName { get; set; }

        public string PassWord { get; set; }
      

    }
}
