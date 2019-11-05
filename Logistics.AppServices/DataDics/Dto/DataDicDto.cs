using Logistics.EF.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace Logistics.AppServices
{

    public class DataDicDto : EntityDtoBase
    {
        /// <summary>
        /// 字典类型编码 
        /// </summary>
        [StringLength(LogisticsConsts.MaxLength64)]
        public  String TypeCode { get; set; }

        /// <summary>
        /// 字典类型名称
        /// </summary>
        [StringLength(LogisticsConsts.MaxLength64)]
        public  String TypeName { get; set; }

        /// <summary>
        /// 项目编码
        /// </summary>
        public  Int32 ItemCode { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        public  String ItemName { get; set; }

        /// <summary>
        /// 项目说明
        /// </summary>
        [StringLength(LogisticsConsts.MaxLength256)]
        public  String ItemRemark { get; set; }

    }
}
