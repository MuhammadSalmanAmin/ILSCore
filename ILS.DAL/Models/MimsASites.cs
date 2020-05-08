using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsASites
    {
        public MimsASites()
        {
            MimsIDemandsDemandeeUnitNavigation = new HashSet<MimsIDemands>();
            MimsIDemandsUnit = new HashSet<MimsIDemands>();
            MimsIDepot = new HashSet<MimsIDepot>();
            MimsWWorkorder = new HashSet<MimsWWorkorder>();
        }

        public int SiteNo { get; set; }
        public string SiteName { get; set; }
        public string SiteType { get; set; }
        public DateTime? InductionDate { get; set; }
        public byte[] SitePic { get; set; }
        public int? Configured { get; set; }

        public virtual ICollection<MimsIDemands> MimsIDemandsDemandeeUnitNavigation { get; set; }
        public virtual ICollection<MimsIDemands> MimsIDemandsUnit { get; set; }
        public virtual ICollection<MimsIDepot> MimsIDepot { get; set; }
        public virtual ICollection<MimsWWorkorder> MimsWWorkorder { get; set; }
    }
}
