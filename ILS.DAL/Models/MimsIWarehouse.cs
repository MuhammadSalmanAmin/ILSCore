using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsIWarehouse
    {
        public MimsIWarehouse()
        {
            MimsIRacks = new HashSet<MimsIRacks>();
        }

        public int? GroupId { get; set; }
        public int WarehouseId { get; set; }
        public string WarehouseName { get; set; }
        public string WarehouseDesc { get; set; }
        public string WarehouseRemarks { get; set; }
        public int? WarehouseOic { get; set; }

        public virtual MimsIGroup Group { get; set; }
        public virtual MimsHPerson WarehouseOicNavigation { get; set; }
        public virtual ICollection<MimsIRacks> MimsIRacks { get; set; }
    }
}
