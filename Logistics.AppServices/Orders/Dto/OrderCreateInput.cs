using Logistics.EF.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Logistics.AppServices
{

    public class OrderCreateInput
    {

        /// <summary>
        /// �ļ���
        /// </summary>
        public  long Sender { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        public  decimal Price { get; set; }

      
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
        public  String PicPath1 { get; set; }

        public String PicPath2 { get; set; }
        public String PicPath3 { get; set; }
        public String PicPath4 { get; set; }

    }
}
