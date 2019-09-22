using Logistics.EF.Core;
using Logistics.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace Logistics.AppServices
{

    public class AddressDto : EntityDtoBase
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
