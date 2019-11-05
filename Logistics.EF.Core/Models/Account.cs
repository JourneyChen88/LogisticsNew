
namespace Logistics.EF.Core
{
    using Logistics.EF.Core;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// �����˻�
    /// </summary>
    public class Account : EntityBase
    {


        /// <summary>
        /// �û�ID
        /// </summary>      
        public virtual long UserId { get; set; }

        /// <summary>
        /// �˺����� 1�����2���ÿ���0δ֪
        /// </summary>
        public virtual int AccountType { get; set; }

        /// <summary>
        /// �˺�
        /// </summary>      
        public virtual String AccountNo { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public virtual string BankName { get; set; }

       
        /// <summary>
        /// �Ƿ�Ĭ���˻�
        /// </summary>
        public virtual Boolean IsDefault { get; set; }



    }
}
