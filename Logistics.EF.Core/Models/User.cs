
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
        /// ����
        /// </summary>
        [StringLength(LogisticsConsts.MaxLength64)]
        public string Name { get; set; }

        public string PassWord { get; set; }
        /// <summary>
        /// ��ע
        /// </summary>
        [StringLength(LogisticsConsts.MaxLength1024)]
        public virtual String Remark { get; set; }

    }
}
