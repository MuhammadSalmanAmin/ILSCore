using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsXAnc
    {
        public MimsXAnc()
        {
            MimsCParts = new HashSet<MimsCParts>();
        }

        public string AncName { get; set; }
        public string AncDesc { get; set; }
        public int AncId { get; set; }

        public virtual ICollection<MimsCParts> MimsCParts { get; set; }
    }
}
