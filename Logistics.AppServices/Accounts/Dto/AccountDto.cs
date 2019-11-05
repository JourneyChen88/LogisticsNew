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
        public  long UserId { get; set; }

        /// <summary>
        /// 账号类型
        /// </summary>
        public  int AccountType { get; set; }

        public string AccountTypeName { get; set; }

        /// <summary>
        /// 账号
        /// </summary>      
        public  String AccountNo { get; set; }

      

        /// <summary>
        /// 银行类型
        /// </summary>
        public string BankName { get; set; }
        /// <summary>
        /// 是否默认账户
        /// </summary>
        public  Boolean IsDefault { get; set; }

    }
}
