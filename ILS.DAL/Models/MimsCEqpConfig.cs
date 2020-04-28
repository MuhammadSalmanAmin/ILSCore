using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsCEqpConfig
    {
        public long _1 { get; set; }
        public long _2 { get; set; }
        public long _3 { get; set; }
        public string _4 { get; set; }
        public string _5 { get; set; }
        public string _6 { get; set; }
        public string _7 { get; set; }
        public string _8 { get; set; }
        public string _9 { get; set; }
        public string _10 { get; set; }
        public string _11 { get; set; }
        public string _12 { get; set; }
        public int? _13 { get; set; }
        public int? _14 { get; set; }
        public int? _15 { get; set; }
        public long Trid { get; set; }

        public virtual MimsCParts _1Navigation { get; set; }
        public virtual MimsCParts _2Navigation { get; set; }
        public virtual MimsCParts _3Navigation { get; set; }
    }
}
