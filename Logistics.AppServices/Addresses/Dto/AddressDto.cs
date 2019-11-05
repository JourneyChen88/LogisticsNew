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
        /// ��ϵ��
        /// </summary>
        [StringLength(LogisticsConsts.MaxLength64)]
        public  String Linker { get; set; }

        /// <summary>
        /// �绰
        /// </summary>
        public  String LinkPhone { get; set; }

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
        public  Boolean IsDefault { get; set; }

    }
}
