using ILS.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILS.Services
{
    public class PartsViewModel
    {
        [DisplayName("Id")]
        [RegularExpression(Regex.NumbersOnly)]
        public long PartId { get; set; }

        [DisplayName("Manufacturer Id")]
        [RegularExpression(Regex.NumbersOnly)]
        public long ManufacturerId { get; set; }

        [DisplayName("Type")]
        [StringLength(1)]
        public string PartType { get; set; }

        [DisplayName("Type Description")]
        [StringLength(20, MinimumLength = 3)]
        public string PartTypeDescription { get; set; }

        [DisplayName("Category")]
        [StringLength(10, MinimumLength = 3)]
        public string PartCategory { get; set; }

        [DisplayName("Manufacturer Category")]
        [StringLength(10, MinimumLength = 3)]
        public string ManufacturerCategory { get; set; }

        [DisplayName("Part Number")]
        [StringLength(50, MinimumLength = 3)]
        public string PartNo { get; set; }

        [DisplayName("Name")]
        [StringLength(100, MinimumLength = 3)]
        public string PartName { get; set; }

        [DisplayName("Currency")]
        [StringLength(10, MinimumLength = 3)]
        public string Currency { get; set; }

        [DisplayName("Unit Price")]
        [RegularExpression(Regex.NumbersOnly)]
        public decimal? UnitPrice { get; set; }


        public List<PartsList> AssociatedParts { get; set; }
    }

    public class PartsList
    {
        public string PartNo { get; set; }
        public string Name { get; set; }
    }
}
