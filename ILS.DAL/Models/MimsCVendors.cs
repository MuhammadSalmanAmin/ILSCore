using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsCVendors
    {
        public MimsCVendors()
        {
            MimsCPartvendorlist = new HashSet<MimsCPartvendorlist>();
            MimsCPartvendors = new HashSet<MimsCPartvendors>();
        }

        public long VendorId { get; set; }
        public string VendorCode { get; set; }
        public string VendorName { get; set; }
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
        public string Remarks { get; set; }
        public int? IsActive { get; set; }
        public decimal? VendorLat { get; set; }
        public decimal? VendorLong { get; set; }
        public byte[] VendorMap { get; set; }

        public virtual ICollection<MimsCPartvendorlist> MimsCPartvendorlist { get; set; }
        public virtual ICollection<MimsCPartvendors> MimsCPartvendors { get; set; }
    }
}
