using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsXSla
    {
        public MimsXSla()
        {
            MimsCParts = new HashSet<MimsCParts>();
        }

        public string SlaCode { get; set; }
        public string SlaDesc { get; set; }
        public int SlaId { get; set; }

        public virtual ICollection<MimsCParts> MimsCParts { get; set; }
    }
}
