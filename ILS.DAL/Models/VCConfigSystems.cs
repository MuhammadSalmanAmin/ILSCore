using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class VCConfigSystems
    {
        public int SiteNo { get; set; }
        public string Eswbs { get; set; }
        public string Peswbs { get; set; }
        public string SiteName { get; set; }
        public string Nomenclature { get; set; }
        public string ParentName { get; set; }
        public string PmsNo { get; set; }
        public string ItemSerialNo { get; set; }
        public string PartNo { get; set; }
        public string Cage { get; set; }
        public string Nsn { get; set; }
    }
}
