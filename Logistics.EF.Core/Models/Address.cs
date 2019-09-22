
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
        /// ��ϵ��
        /// </summary>
        [StringLength(LogisticsConsts.MaxLength64)]
        public virtual String Linker { get; set; }

        /// <summary>
        /// �绰
        /// </summary>
        public virtual String LinkPhone { get; set; }

        /// <summary>
        /// ��ϸ��Ϣ
        /// </summary>
        [StringLength(LogisticsConsts.MaxLength256)]
        public virtual String DetailInfo { get; set; }

        

        /// <summary>
        /// �Ƿ�Ĭ�ϵ�ַ
        /// </summary>
        public virtual Boolean IsDefault { get; set; }



    }
}
