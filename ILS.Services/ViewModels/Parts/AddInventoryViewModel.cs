using ILS.Helpers;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ILS
{
    public class AddInventoryViewModel
    {
 
        [Required]
        [StringLength(100)]
        [RegularExpression(Regex.AlphabetsOnly)]
        public string Name { get; set; }
        public string Description { get; set; }
        public string SelectedPartCategory { get; set; }
       
        
        [DisplayName("Part Category")]
        public IEnumerable<SelectListItem> PartCategory { get; set; }
    }
}