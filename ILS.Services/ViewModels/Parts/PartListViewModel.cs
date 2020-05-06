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

  
    public class CustomClass
    {
        public string  PartId { get; set; }
        public string ManufacturerName { get; set; }
        public string Description { get; set; }
        public string PartNumber { get; set; }
        public string PartName { get; set; }
        public int? Quantity { get; set; }

    }
}