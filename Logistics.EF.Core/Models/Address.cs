
namespace Logistics.EF.Core
{
    using Logistics;
    using Logistics.EF.Core;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Address : EntityBase
    {
        public virtual long UserId { get; set; }

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
        /// ����ʡ���أ�
        /// </summary>
        public virtual String Location { get; set; }

        /// <summary>
        /// ��ϸ��ַ
        /// </summary>
        [StringLength(LogisticsConsts.MaxLength256)]
        public virtual String Detail { get; set; }

        

        /// <summary>
        /// �Ƿ�Ĭ�ϵ�ַ
        /// </summary>
        public virtual Boolean IsDefault { get; set; }



    }
}
