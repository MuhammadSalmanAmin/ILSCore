using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsXAp
    {
        public MimsXAp()
        {
            MimsCParts = new HashSet<MimsCParts>();
        }

        public int ApId { get; set; }
        public string ApName { get; set; }
        public string ApDesc { get; set; }

        public virtual ICollection<MimsCParts> MimsCParts { get; set; }
    }
}
