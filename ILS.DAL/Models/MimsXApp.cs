using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsXApp
    {
        public MimsXApp()
        {
            MimsCParts = new HashSet<MimsCParts>();
        }

        public int AppId { get; set; }
        public string AppCode { get; set; }
        public string AppDesc { get; set; }

        public virtual ICollection<MimsCParts> MimsCParts { get; set; }
    }
}
