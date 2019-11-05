
namespace Logistics.EF.Core
{
    using Logistics.EF.Core;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// 银行账户
    /// </summary>
    public class Account : EntityBase
    {


        /// <summary>
        /// 用户ID
        /// </summary>      
        public virtual long UserId { get; set; }

        /// <summary>
        /// 账号类型 1储蓄卡，2信用卡，0未知
        /// </summary>
        public virtual int AccountType { get; set; }

        /// <summary>
        /// 账号
        /// </summary>      
        public virtual String AccountNo { get; set; }

        /// <summary>
        /// 银行类型
        /// </summary>
        public virtual string BankName { get; set; }

       
        /// <summary>
        /// 是否默认账户
        /// </summary>
        public virtual Boolean IsDefault { get; set; }



    }
}
