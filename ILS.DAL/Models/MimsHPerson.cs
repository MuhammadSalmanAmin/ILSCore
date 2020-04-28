using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsHPerson
    {
        public MimsHPerson()
        {
            MimsIDepot = new HashSet<MimsIDepot>();
            MimsIGroup = new HashSet<MimsIGroup>();
            MimsIWarehouse = new HashSet<MimsIWarehouse>();
            MimsWWorkcnterHr = new HashSet<MimsWWorkcnterHr>();
        }

        public int PersonId { get; set; }
        public string Pno { get; set; }
        public string Name { get; set; }
        public int? RankId { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public string Fname { get; set; }
        public string Remarks { get; set; }
        public int? Fi1 { get; set; }
        public int? Fi2 { get; set; }
        public int? Fi3 { get; set; }
        public string Fv1 { get; set; }
        public string Fv2 { get; set; }
        public byte[] PersonPic { get; set; }

        public virtual MimsHRanks Rank { get; set; }
        public virtual ICollection<MimsIDepot> MimsIDepot { get; set; }
        public virtual ICollection<MimsIGroup> MimsIGroup { get; set; }
        public virtual ICollection<MimsIWarehouse> MimsIWarehouse { get; set; }
        public virtual ICollection<MimsWWorkcnterHr> MimsWWorkcnterHr { get; set; }
    }
}
