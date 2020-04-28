using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsXDemandStatus
    {
        public MimsXDemandStatus()
        {
            MimsIDemands = new HashSet<MimsIDemands>();
        }

        public int DemandStatusId { get; set; }
        public string DemandStatus { get; set; }

        public virtual ICollection<MimsIDemands> MimsIDemands { get; set; }
    }
}
