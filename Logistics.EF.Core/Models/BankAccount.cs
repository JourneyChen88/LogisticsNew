
namespace Logistics.Models
{
    using Logistics.Models;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// 银行账户
    /// </summary>
    public class BankAccount : EntityBase
    {


        /// <summary>
        /// 用户ID
        /// </summary>      
        public virtual Guid UserId { get; set; }

        /// <summary>
        /// 账号类型
        /// </summary>
        public virtual int AccountType { get; set; }

        /// <summary>
        /// 账号
        /// </summary>      
        public virtual String AccountNo { get; set; }

        /// <summary>
        /// 所属银行类型
        /// </summary>
        public virtual int? BankType { get; set; }
        /// <summary>
        /// 是否默认账户
        /// </summary>
        public virtual Boolean IsDefault { get; set; }



    }
}
