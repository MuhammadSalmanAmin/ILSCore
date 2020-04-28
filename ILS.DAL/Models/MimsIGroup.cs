using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsIGroup
    {
        public MimsIGroup()
        {
            MimsIWarehouse = new HashSet<MimsIWarehouse>();
        }

        public int? DepotId { get; set; }
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public string GroupDesc { get; set; }
        public int? GroupOfficer { get; set; }
        public string Reamrks { get; set; }

        public virtual MimsIDepot Depot { get; set; }
        public virtual MimsHPerson GroupOfficerNavigation { get; set; }
        public virtual ICollection<MimsIWarehouse> MimsIWarehouse { get; set; }
    }
}
