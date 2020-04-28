using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ILS
{
    public class PartListViewModel
    {
        public string PartNumber { get; set; }
        public string PartName { get; set; }
        public string  Quantity { get; set; }
        public string ManufacturerName { get; set; }
        public string TypeDescription { get; set; }

        public List<PartListViewModel> AvailableParts { get; set; }
    }
}