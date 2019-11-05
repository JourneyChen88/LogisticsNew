
namespace Logistics.EF.Core
{
    using Logistics.EF.Core;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// �����ֵ�
    /// </summary>
    public class DataDic : EntityBase
    {

        /// <summary>
        /// �ֵ����ͱ��� 
        /// </summary>
        [StringLength(LogisticsConsts.MaxLength64)]
        public virtual String TypeCode { get; set; }

        /// <summary>
        /// �ֵ���������
        /// </summary>
        [StringLength(LogisticsConsts.MaxLength64)]
        public virtual String TypeName { get; set; }

        /// <summary>
        /// ��Ŀ����
        /// </summary>
        public virtual Int32 ItemCode { get; set; }

        /// <summary>
        /// ��Ŀ����
        /// </summary>
        public virtual String ItemName { get; set; }

        /// <summary>
        /// ��Ŀ˵��
        /// </summary>
        [StringLength(LogisticsConsts.MaxLength256)]
        public virtual String ItemRemark { get; set; }



    }
}
