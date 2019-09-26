using Logistics.EF.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace Logistics.EF.Core
{
    public class OrderDetail : EntityBase
    {

        public virtual Guid OrderId { get; set; }
        /// <summary>
        /// 序号（自动生成）
        /// </summary>
        public virtual int SeqNo { get; set; }
        /// <summary>
        /// 物品名字
        /// </summary>
        public virtual String GoodsName { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public virtual int GoodsQty { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public virtual int GoodsType { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [StringLength(LogisticsConsts.MaxLength256)]
        public virtual String Remark { get; set; }
    }
}
