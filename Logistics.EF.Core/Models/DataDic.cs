
namespace Logistics.EF.Core
{
    using Logistics.EF.Core;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// 数据字典
    /// </summary>
    public class DataDic : EntityBase
    {

        /// <summary>
        /// 字典类型编码 
        /// </summary>
        [StringLength(LogisticsConsts.MaxLength64)]
        public virtual String TypeCode { get; set; }

        /// <summary>
        /// 字典类型名称
        /// </summary>
        [StringLength(LogisticsConsts.MaxLength64)]
        public virtual String TypeName { get; set; }

        /// <summary>
        /// 项目编码
        /// </summary>
        public virtual Int32 ItemCode { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        public virtual String ItemName { get; set; }

        /// <summary>
        /// 项目说明
        /// </summary>
        [StringLength(LogisticsConsts.MaxLength256)]
        public virtual String ItemRemark { get; set; }



    }
}
