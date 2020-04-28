using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsIRacks
    {
        public MimsIRacks()
        {
            MimsIBins = new HashSet<MimsIBins>();
        }

        public int? WarehouseId { get; set; }
        public int RackId { get; set; }
        public string RackNo { get; set; }
        public string RackLoc { get; set; }
        public string RackDesc { get; set; }
        public string RackRemarks { get; set; }

        public virtual MimsIWarehouse Warehouse { get; set; }
        public virtual ICollection<MimsIBins> MimsIBins { get; set; }
    }
}
