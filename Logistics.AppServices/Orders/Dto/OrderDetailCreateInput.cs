using Logistics.EF.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace Logistics.AppServices
{
    public class OrderDetailCreateInput
    {

        /// <summary>
        /// 序号（自动生成）
        /// </summary>
        public  int SeqNo { get; set; }
        /// <summary>
        /// 物品名字
        /// </summary>
        public  String GoodsName { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public  int GoodsQty { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public  int GoodsType { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [StringLength(LogisticsConsts.MaxLength256)]
        public  String Remark { get; set; }
    }
}
