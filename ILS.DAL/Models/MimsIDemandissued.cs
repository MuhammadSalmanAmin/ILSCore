using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsIDemandissued
    {
        public long DemandId { get; set; }
        public decimal? IssueQty { get; set; }
        public DateTime? IssueDate { get; set; }
        public string Remarks { get; set; }
        public int? IsReceived { get; set; }
        public DateTime? ReceivedDate { get; set; }

        public virtual MimsIDemands Demand { get; set; }
    }
}
