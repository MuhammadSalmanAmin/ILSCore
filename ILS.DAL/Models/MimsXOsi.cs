using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsXOsi
    {
        public MimsXOsi()
        {
            MimsCParts = new HashSet<MimsCParts>();
        }

        public string OsiCode { get; set; }
        public string OsiDesc { get; set; }
        public int OsiId { get; set; }

        public virtual ICollection<MimsCParts> MimsCParts { get; set; }
    }
}
