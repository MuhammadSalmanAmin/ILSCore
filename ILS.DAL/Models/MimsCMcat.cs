using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsCMcat
    {
        public MimsCMcat()
        {
            MimsCParts = new HashSet<MimsCParts>();
        }

        public string Mcat { get; set; }
        public string McatDesc { get; set; }
        public string Remarks { get; set; }

        public virtual ICollection<MimsCParts> MimsCParts { get; set; }
    }
}
