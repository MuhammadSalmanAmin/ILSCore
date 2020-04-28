using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsXSecurity
    {
        public MimsXSecurity()
        {
            MimsCParts = new HashSet<MimsCParts>();
        }

        public string SecurityCode { get; set; }
        public string SecurityDesc { get; set; }
        public int SecurityId { get; set; }

        public virtual ICollection<MimsCParts> MimsCParts { get; set; }
    }
}
