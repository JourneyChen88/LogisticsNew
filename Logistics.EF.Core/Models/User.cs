
namespace Logistics.EF.Core
{
    using Logistics;
    using Logistics.EF.Core;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// �û�
    /// </summary>
    public class User : EntityBase<long>
    {
        /// <summary>
        /// �绰
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// �û���
        /// </summary>
        [StringLength(LogisticsConsts.MaxLength64)]
        public string UserName { get; set; }

        public string PassWord { get; set; }


        /// <summary>
        /// ��ʵ����
        /// </summary>
        [StringLength(LogisticsConsts.MaxLength64)]
        public string RealName { get; set; }

        /// <summary>
        /// ���֤��
        /// </summary>
        [StringLength(20)]
        public string IdCardNo { get; set; }

        /// <summary>
        /// �Ƿ�ʵ����֤
        /// </summary>
        public bool IsAuthentication { get; set; }
        /// <summary>
        /// ��ע
        /// </summary>
        [StringLength(LogisticsConsts.MaxLength1024)]
        public virtual String Remark { get; set; }

    }
}
