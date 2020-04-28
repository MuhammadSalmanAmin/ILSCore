using ILS.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ILS
{
    public class AddEditCageViewModel
    {
        
        public int ManufacturerId { get; set; }
        
        [Required]
        [StringLength(250)]
        [RegularExpression(Regex.AlphabetsWithSpaces)]
        [DisplayName("Manufacturer Name")]
        public string ManufacturerName { get; set; }
        [Required]
        [StringLength(10)]
        [DisplayName("Cage Code")]
        public string CageCode { get; set; }
        [Required]
        [StringLength(3, MinimumLength =3)]
        public string ManufacturerCode { get; set; }
        [Required]
        public bool IsVendor { get; set; }
        [StringLength(250)]
        public string Address { get; set; }
        [StringLength(250)]
        public string City { get; set; }
        [StringLength(250)]
        public string Country { get; set; }
        [StringLength(250)]
        public string Zip { get; set; }
        [StringLength(250)]
        public string Telephone { get; set; }
        [StringLength(250)]
        public string Fax { get; set; }
        [StringLength(250)]
        public string Email { get; set; }
        [StringLength(250)]
        public string URL { get; set; }
        [StringLength(250)]
        public string Remarks { get; set; }
    }
}
