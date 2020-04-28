using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsIDemands
    {
        public long DemandId { get; set; }
        public string DemandNo { get; set; }
        public int? DemandTypeId { get; set; }
        public int DemandeeUnit { get; set; }
        public int? UnitId { get; set; }
        public long? PartId { get; set; }
        public decimal? Qty { get; set; }
        public string UomId { get; set; }
        public string Refernce { get; set; }
        public DateTime? DemandDate { get; set; }
        public int? StatusId { get; set; }
        public DateTime? StatusDate { get; set; }

        public virtual MimsXDemandtype DemandType { get; set; }
        public virtual MimsASites DemandeeUnitNavigation { get; set; }
        public virtual MimsCParts Part { get; set; }
        public virtual MimsXDemandStatus Status { get; set; }
        public virtual MimsASites Unit { get; set; }
        public virtual MimsIDemandissued MimsIDemandissued { get; set; }
    }
}
