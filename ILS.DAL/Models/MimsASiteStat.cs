using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsASiteStat
    {
        public int SiteNo { get; set; }
        public string Image { get; set; }
        public decimal? OpsReadiness { get; set; }
        public decimal? OpsAvailability { get; set; }
        public int? OpsDefect { get; set; }
        public int? TypeCommand { get; set; }
        public string Status { get; set; }
    }
}
