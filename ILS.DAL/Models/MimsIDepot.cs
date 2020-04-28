using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsIDepot
    {
        public MimsIDepot()
        {
            MimsIGroup = new HashSet<MimsIGroup>();
        }

        public int DeoptId { get; set; }
        public string DepotCode { get; set; }
        public string DepotName { get; set; }
        public string DepotDesc { get; set; }
        public decimal? DepotArea { get; set; }
        public string DepotLoc { get; set; }
        public decimal? DeoptLat { get; set; }
        public decimal? DepotLong { get; set; }
        public int? DepotCo { get; set; }
        public int? DepotUnit { get; set; }
        public byte[] DepotImage { get; set; }
        public byte[] DepotMapLoc { get; set; }

        public virtual MimsHPerson DepotCoNavigation { get; set; }
        public virtual MimsASites DepotUnitNavigation { get; set; }
        public virtual ICollection<MimsIGroup> MimsIGroup { get; set; }
    }
}
