using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsXDemandtype
    {
        public MimsXDemandtype()
        {
            MimsIDemands = new HashSet<MimsIDemands>();
        }

        public int DemandTypeId { get; set; }
        public string DemandTypeName { get; set; }

        public virtual ICollection<MimsIDemands> MimsIDemands { get; set; }
    }
}
