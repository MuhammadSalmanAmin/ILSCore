using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsXTss
    {
        public MimsXTss()
        {
            MimsCParts = new HashSet<MimsCParts>();
        }

        public string TssCode { get; set; }
        public string TssDesc { get; set; }
        public int TssId { get; set; }

        public virtual ICollection<MimsCParts> MimsCParts { get; set; }
    }
}
