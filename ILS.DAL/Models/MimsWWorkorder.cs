using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsWWorkorder
    {
        public int WorkOrderId { get; set; }
        public string WorkOrderNo { get; set; }
        public int? WorkOrderStatus { get; set; }
        public int? WorkOrderType { get; set; }
        public string WorkOrderRemarks { get; set; }
        public string OpdefRequsitionNo { get; set; }
        public int? InitiatingUnit { get; set; }

        public virtual MimsASites InitiatingUnitNavigation { get; set; }
        public virtual MimsWStatus WorkOrderStatusNavigation { get; set; }
        public virtual MimsWorkorderType WorkOrderTypeNavigation { get; set; }
    }
}
