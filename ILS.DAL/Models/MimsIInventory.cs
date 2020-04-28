using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsIInventory
    {
        public int PartId { get; set; }
        public int BinId { get; set; }
        public int? DepotId { get; set; }
        public int? GroupId { get; set; }
        public int? WarehouseId { get; set; }
        public int? RackId { get; set; }
        public decimal? Qty { get; set; }

        public virtual MimsIBins Bin { get; set; }
        public virtual MimsIDepot Depot { get; set; }
        public virtual MimsIGroup Group { get; set; }
        public virtual MimsIRacks Rack { get; set; }
        public virtual MimsIWarehouse Warehouse { get; set; }
    }
}
