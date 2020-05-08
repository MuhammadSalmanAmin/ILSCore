using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsXSmic
    {
        public MimsXSmic()
        {
            MimsCParts = new HashSet<MimsCParts>();
        }

        public string SmicCode { get; set; }
        public string SmicDesc { get; set; }
        public int SmicId { get; set; }

        public virtual ICollection<MimsCParts> MimsCParts { get; set; }
    }
}
