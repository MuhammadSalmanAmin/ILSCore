using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsXGroup
    {
        public MimsXGroup()
        {
            MimsCParts = new HashSet<MimsCParts>();
        }

        public string GrouopCode { get; set; }
        public string GroupDesc { get; set; }
        public int GroupId { get; set; }

        public virtual ICollection<MimsCParts> MimsCParts { get; set; }
    }
}
