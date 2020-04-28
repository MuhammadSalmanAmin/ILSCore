using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsXSmc
    {
        public MimsXSmc()
        {
            MimsCParts = new HashSet<MimsCParts>();
        }

        public string SmcCode { get; set; }
        public string SmcDesc { get; set; }
        public int SmcId { get; set; }

        public virtual ICollection<MimsCParts> MimsCParts { get; set; }
    }
}
