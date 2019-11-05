using Logistics.EF.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace Logistics.AppServices
{

    public class AccountCreateInput
    {

        /// <summary>
        /// �û�ID
        /// </summary>      
        public  long UserId { get; set; }

        /// <summary>
        /// �˺�����
        /// </summary>
        public  int AccountType { get; set; }

        /// <summary>
        /// �˺�
        /// </summary>      
        public  String AccountNo { get; set; }

        /// <summary>
        /// ������������
        /// </summary>
        public  string BankName { get; set; }

        
        /// <summary>
        /// �Ƿ�Ĭ���˻�
        /// </summary>
        public  Boolean IsDefault { get; set; }

    }
}
