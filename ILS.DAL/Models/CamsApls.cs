using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class CamsApls
    {
        public string AplNo { get; set; }
        public string AplName { get; set; }
        public string Model { get; set; }
        public string Nsn { get; set; }
        public string Clsgrp { get; set; }
        public string Niin { get; set; }
        public string AplPartno { get; set; }
        public string ManufacturerNo { get; set; }
    }
}
