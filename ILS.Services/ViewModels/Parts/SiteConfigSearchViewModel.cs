using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ILS
{
    public class SiteConfigSearchViewModel
    {
        public string SiteId { get; set; }
        public string SchemeId { get; set; }

        [DisplayName("Select Site")]
        public IEnumerable<SelectListItem> ConfiguredSitesList { get; set; }

        [DisplayName("Schemes")]
        public IEnumerable<SelectListItem> Schemes { get; set; }
    }
}
