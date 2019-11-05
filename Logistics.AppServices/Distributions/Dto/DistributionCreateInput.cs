using Logistics.EF.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Logistics.AppServices
{

    public class DistributionCreateInput
    {

        /// <summary>
        /// �������
        /// </summary>
        public  Guid OrderId { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        public  long Deliver { get; set; }

        /// <summary>
        /// ǩ����
        /// </summary>
        public  String Signer { get; set; }

        /// <summary>
        /// ǩ��ʱ��
        /// </summary>
        public  DateTime? SignTime { get; set; }

    }
}
