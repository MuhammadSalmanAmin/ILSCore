using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsXShelflife
    {
        public MimsXShelflife()
        {
            MimsCParts = new HashSet<MimsCParts>();
        }

        public int SlId { get; set; }
        public string SlCode { get; set; }
        public string SlDesc { get; set; }

        public virtual ICollection<MimsCParts> MimsCParts { get; set; }
    }
}
