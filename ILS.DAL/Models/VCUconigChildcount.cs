using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class VCUconigChildcount
    {
        public int SiteNo { get; set; }
        public string Peswbs { get; set; }
        public int? Childcount { get; set; }
        public string Maxchildindex { get; set; }
    }
}
