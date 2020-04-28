using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsXAc
    {
        public MimsXAc()
        {
            MimsCParts = new HashSet<MimsCParts>();
        }

        public int AcId { get; set; }
        public string AcName { get; set; }
        public string AcDesc { get; set; }

        public virtual ICollection<MimsCParts> MimsCParts { get; set; }
    }
}
