using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsWoWorkcenters
    {
        public int WoId { get; set; }
        public int WcId { get; set; }
        public int? IsKeyShop { get; set; }
        public string Remarks { get; set; }

        public virtual MimsXYesno IsKeyShopNavigation { get; set; }
    }
}
