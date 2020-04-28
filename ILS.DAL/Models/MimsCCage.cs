using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsCCage
    {
        public MimsCCage()
        {
            MimsCParts = new HashSet<MimsCParts>();
        }

        public long ManId { get; set; }
        public string ManCode { get; set; }
        public string Cage { get; set; }
        public string ManufacturerName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Zip { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Url { get; set; }
        public string AddBy { get; set; }
        public DateTime? AddDate { get; set; }
        public string LeditedBy { get; set; }
        public DateTime? LeditedDate { get; set; }
        public int? IsVendor { get; set; }
        public string Remarks { get; set; }

        public virtual MimsCCountry CountryNavigation { get; set; }
        public virtual ICollection<MimsCParts> MimsCParts { get; set; }
    }
}
