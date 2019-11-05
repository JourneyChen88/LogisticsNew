using Logistics.EF.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace Logistics.AppServices
{

    public class OrderHisDto 
    {
        public  string OrderNo { get; set; }
        /// <summary>
        /// �ļ���
        /// </summary>
        public  string SenderName { get; set; }

        public string SenderPhone { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        public  decimal Price { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        public  string DeliverName { get; set; }

        public string DeliverPhone { get; set; }
        /// <summary>
        /// ������ַ
        /// </summary>
        [StringLength(LogisticsConsts.MaxLength64)]
        public  string MailingAddress { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public  float MailingLng { get; set; }
        /// <summary>
        /// ����γ��
        /// </summary>
        public  float MailingLat { get; set; }

        /// <summary>
        /// �ռ���
        /// </summary>
        public  string Receiver { get; set; }

        /// <summary>
        /// �ռ��˵绰
        /// </summary>
        public  string ReceiverPhone { get; set; }

        /// <summary>
        /// Ŀ�ĵ�
        /// </summary>
        public  string Destination { get; set; }

        /// <summary>
        /// Ŀ�ĵؾ���
        /// </summary>
        public  float DestLng { get; set; }

        /// <summary>
        /// Ŀ�ĵ�γ��
        /// </summary>
        public  float DestLat { get; set; }


        /// <summary>
        /// ͼƬ·��
        /// </summary>
        public virtual String PicPath1 { get; set; }

        public virtual String PicPath2 { get; set; }
        public virtual String PicPath3 { get; set; }
        public virtual String PicPath4 { get; set; }



        /// <summary>
        /// ����͵�ʱ��
        /// </summary>
        public  DateTime? DeadLine { get; set; }



        /// <summary>
        /// ����״̬
        /// </summary>
        public  int OrderStatus { get; set; }



        /// <summary>
        /// ��ע
        /// </summary>
        [StringLength(LogisticsConsts.MaxLength256)]
        public  String Remark { get; set; }

        /// <summary>
        /// ״̬��Ϣ
        /// </summary>
        public String StatusInfo { get; set; }
    }
}
