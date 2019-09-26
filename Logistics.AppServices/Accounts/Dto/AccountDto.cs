using Logistics.EF.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace Logistics.AppServices
{

    public class AccountDto : EntityDtoBase
    {
        /// <summary>
        /// 用户ID
        /// </summary>      
        public virtual long UserId { get; set; }

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
