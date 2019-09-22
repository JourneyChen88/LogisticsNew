using Logistics.EF.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace Logistics.AppServices
{

    public class LoginInput
    {
        /// <summary>
        /// µç»°
        /// </summary>
        public string Phone { get; set; }

        public string PassWord { get; set; }

    }
}
