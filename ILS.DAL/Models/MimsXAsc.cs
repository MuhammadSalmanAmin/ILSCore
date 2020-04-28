using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsXAsc
    {
        public MimsXAsc()
        {
            MimsCParts = new HashSet<MimsCParts>();
        }

        public string AscName { get; set; }
        public string AscDesc { get; set; }
        public int AscId { get; set; }

        public virtual ICollection<MimsCParts> MimsCParts { get; set; }
    }
}
