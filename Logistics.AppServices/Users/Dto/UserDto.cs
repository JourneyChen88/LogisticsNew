using Logistics.EF.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace Logistics.AppServices
{

    public class UserDto: EntityDtoBase<long>
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
        /// <summary>
        /// ��ע
        /// </summary>
        [StringLength(LogisticsConsts.MaxLength1024)]
        public virtual String Remark { get; set; }



        /// <summary>
        /// ����
        /// </summary>
        [StringLength(LogisticsConsts.MaxLength64)]
        public string RealName { get; set; }

        /// <summary>
        /// ���֤��
        /// </summary>
        [StringLength(LogisticsConsts.MaxLength64)]
        public string IdCardNo{ get; set; }

        

    }
}
