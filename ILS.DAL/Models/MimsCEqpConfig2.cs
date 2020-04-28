using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsCEqpConfig2
    {
        public string Endpart { get; set; }
        public string Part { get; set; }
        public string Ppart { get; set; }
        public string Eswbs { get; set; }
        public string Peswbs { get; set; }
        public string Configno2 { get; set; }
        public string Pconfigno2 { get; set; }
        public string Configno { get; set; }
        public string Pconfigno { get; set; }
        public string Configid { get; set; }
        public string Pconfigid { get; set; }
        public string PartName { get; set; }
        public int? Indlevel { get; set; }
        public int? Pchiildcount { get; set; }
        public int? Indcount { get; set; }
        public int Trid { get; set; }
    }
}
