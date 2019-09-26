
namespace Logistics.EF.Core
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// ֧��
    /// </summary>
    public class Pay : EntityBase
    {


        /// <summary>
        /// ����ID
        /// </summary>      
        public virtual Guid OrderId { get; set; }
        /// <summary>
        /// ֧����ʽ
        /// </summary>
        public virtual int PayMethod { get; set; }
        /// <summary>
        /// ֧���˺�
        /// </summary>      
        public virtual String PayAccount { get; set; }
        /// <summary>
        /// ֧�����
        /// </summary>
        public virtual decimal PayAmount { get; set; }
        /// <summary>
        /// ֧��״̬
        /// </summary>
        public virtual int PayStatus { get; set; }



    }
}
