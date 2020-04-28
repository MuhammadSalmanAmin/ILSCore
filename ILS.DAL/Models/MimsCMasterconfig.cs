using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsCMasterconfig
    {
        public string Eswbs { get; set; }
        public string Peswbs { get; set; }
        public string Nomenclature { get; set; }
        public int? Applicable { get; set; }
    }
}
