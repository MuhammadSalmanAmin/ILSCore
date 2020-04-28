using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class VUconfigSystemchilds
    {
        public int SiteNo { get; set; }
        public string Eswbs { get; set; }
        public string Nomenclature { get; set; }
        public long Partid { get; set; }
        public int Childcount { get; set; }
    }
}
