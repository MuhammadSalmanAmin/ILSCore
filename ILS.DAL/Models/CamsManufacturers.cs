using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class CamsManufacturers
    {
        public string ManufacturerNo { get; set; }
        public string ManufacturerName { get; set; }
        public string Cage { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string TelNo { get; set; }
        public string FaxNo { get; set; }
        public string Email { get; set; }
        public string VendorNo { get; set; }
        public int UpdateStatus { get; set; }
        public int UpdateRevision { get; set; }
        public byte[] ManufacturerImg { get; set; }
        public byte[] ManufacturerMap { get; set; }
    }
}
