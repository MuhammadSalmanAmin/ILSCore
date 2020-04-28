using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class VASiteStat
    {
        public int SiteNo { get; set; }
        public string SiteName { get; set; }
        public string Image { get; set; }
        public decimal? OpsReadiness { get; set; }
        public decimal? OpsAvailability { get; set; }
        public int? OpsDefect { get; set; }
        public string TypeCommandName { get; set; }
        public string CommandName { get; set; }
        public string Status { get; set; }
    }
}
