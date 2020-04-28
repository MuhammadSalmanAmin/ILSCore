using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsXUpkeep
    {
        public MimsXUpkeep()
        {
            MimsCUnitconfig = new HashSet<MimsCUnitconfig>();
        }

        public string UpkeepName { get; set; }
        public string UpkeepDesc { get; set; }
        public int UpkeepId { get; set; }

        public virtual ICollection<MimsCUnitconfig> MimsCUnitconfig { get; set; }
    }
}
