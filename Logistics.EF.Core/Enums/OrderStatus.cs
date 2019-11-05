using System;
using System.Collections.Generic;
using System.Text;

namespace Logistics.EF.Core
{
    /// <summary>
    /// 订单状态
    /// </summary>
    public enum OrderStatusEnum
    {
        /// <summary>
        /// 待接单
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// 已付款
        /// </summary>
        Paid,

        /// <summary>
        /// 已接单
        /// </summary>
        Accepted,

        /// <summary>
        /// 已签收
        /// </summary>
        Signed,

    }
}
