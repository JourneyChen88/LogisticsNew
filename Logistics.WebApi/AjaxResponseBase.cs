using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Logistics.WebApi
{
    public abstract class AjaxResponseBase
    {
        /// <summary>
        /// 返回编码，1成功，0失败
        /// </summary>
       
        public int code { get; set; }

        /// <summary>
        /// Error details (Must and only set if <see cref="Success"/> is false).
        /// </summary>
        public string info { get; set; }

    }
}
