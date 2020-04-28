using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class VCCpartCount
    {
        public long Part { get; set; }
        public int? CpartCount { get; set; }
        public int? TotalCparts { get; set; }
    }
}
