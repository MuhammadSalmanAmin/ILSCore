using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsXMec
    {
        public MimsXMec()
        {
            MimsCParts = new HashSet<MimsCParts>();
        }

        public int Mec { get; set; }
        public string MecDesc { get; set; }

        public virtual ICollection<MimsCParts> MimsCParts { get; set; }
    }
}
