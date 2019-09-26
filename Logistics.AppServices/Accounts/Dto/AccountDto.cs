using Logistics.EF.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace Logistics.AppServices
{

    public class AccountDto : EntityDtoBase
    {
        /// <summary>
        /// �û�ID
        /// </summary>      
        public virtual long UserId { get; set; }

        /// <summary>
        /// �˺�����
        /// </summary>
        public virtual int AccountType { get; set; }

        /// <summary>
        /// �˺�
        /// </summary>      
        public virtual String AccountNo { get; set; }

        /// <summary>
        /// ������������
        /// </summary>
        public virtual int? BankType { get; set; }
        /// <summary>
        /// �Ƿ�Ĭ���˻�
        /// </summary>
        public virtual Boolean IsDefault { get; set; }

    }
}
