using Logistics.EF.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace Logistics.AppServices
{

    public class RegisterDto
    {
        /// <summary>
        /// µç»°
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Ãû³Æ
        /// </summary>
        [StringLength(LogisticsConsts.MaxLength64)]
        public string UserName { get; set; }

        public string PassWord { get; set; }
      

    }
}
