using Logistics.EF.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace Logistics.AppServices
{

    public class DataDicDto : EntityDtoBase
    {
        /// <summary>
        /// �ֵ����ͱ��� 
        /// </summary>
        [StringLength(LogisticsConsts.MaxLength64)]
        public  String TypeCode { get; set; }

        /// <summary>
        /// �ֵ���������
        /// </summary>
        [StringLength(LogisticsConsts.MaxLength64)]
        public  String TypeName { get; set; }

        /// <summary>
        /// ��Ŀ����
        /// </summary>
        public  Int32 ItemCode { get; set; }

        /// <summary>
        /// ��Ŀ����
        /// </summary>
        public  String ItemName { get; set; }

        /// <summary>
        /// ��Ŀ˵��
        /// </summary>
        [StringLength(LogisticsConsts.MaxLength256)]
        public  String ItemRemark { get; set; }

    }
}
