using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsCApl
    {
        public long AplId { get; set; }
        public string Apl { get; set; }
        public long? AplpartId { get; set; }

        public virtual MimsCParts Aplpart { get; set; }
    }
}
