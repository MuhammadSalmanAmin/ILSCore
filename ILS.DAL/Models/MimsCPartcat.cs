using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsCPartcat
    {
        public MimsCPartcat()
        {
            MimsCParts = new HashSet<MimsCParts>();
        }

        public string PartCat { get; set; }
        public string PartcatDesc { get; set; }
        public string Remarks { get; set; }

        public virtual ICollection<MimsCParts> MimsCParts { get; set; }
    }
}
