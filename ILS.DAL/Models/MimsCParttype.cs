using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsCParttype
    {
        public MimsCParttype()
        {
            MimsCParts = new HashSet<MimsCParts>();
        }

        public string PartType { get; set; }
        public string TypeDesc { get; set; }

        public virtual ICollection<MimsCParts> MimsCParts { get; set; }
    }
}
