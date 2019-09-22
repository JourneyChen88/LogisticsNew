
namespace Logistics.Models
{
    using Logistics.Models;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// �����˻�
    /// </summary>
    public class BankAccount : EntityBase
    {


        /// <summary>
        /// �û�ID
        /// </summary>      
        public virtual Guid UserId { get; set; }

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
