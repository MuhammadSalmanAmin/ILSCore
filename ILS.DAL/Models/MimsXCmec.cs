using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsXCmec
    {
        public MimsXCmec()
        {
            MimsCUnitconfig = new HashSet<MimsCUnitconfig>();
        }

        public string CmecDesc { get; set; }
        public int Cmec { get; set; }

        public virtual ICollection<MimsCUnitconfig> MimsCUnitconfig { get; set; }
    }
}
