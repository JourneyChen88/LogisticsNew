using Logistics.EF.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace Logistics.AppServices
{

    public class OrderDto : EntityDtoBase
    {
        /// <summary>
        /// ����������
        /// </summary>
        public virtual Guid OrderUser { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        public virtual decimal Price { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        public virtual Guid? DeliverUser { get; set; }
        /// <summary>
        /// ������ַ
        /// </summary>
        [StringLength(LogisticsConsts.MaxLength64)]
        public virtual string MailingAddress { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public virtual float MailingLng { get; set; }
        /// <summary>
        /// ����γ��
        /// </summary>
        public virtual float MailingLat { get; set; }

        /// <summary>
        /// Ŀ�ĵ�
        /// </summary>
        public virtual string Dstination { get; set; }

        /// <summary>
        /// Ŀ�ĵؾ���
        /// </summary>
        public virtual float DestLng { get; set; }

        /// <summary>
        /// Ŀ�ĵ�γ��
        /// </summary>
        public virtual float DestLat { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public virtual int Qty { get; set; }



        /// <summary>
        /// ����͵�ʱ��
        /// </summary>
        public virtual DateTime? DeadLine { get; set; }



        /// <summary>
        /// ����״̬
        /// </summary>
        public virtual int OrderStatus { get; set; }



        /// <summary>
        /// ��ע
        /// </summary>
        [StringLength(LogisticsConsts.MaxLength256)]
        public virtual String Remark { get; set; }

    }
}
