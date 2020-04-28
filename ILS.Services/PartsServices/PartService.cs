using ILS.DAL.Models;
using ILS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ILS.Services
{
    public class PartService : IPartsService
    {
        ILMMContext _context = new ILMMContext();

        public override void AddParts(AddPartViewModel model)
        {
            try
            {
                model.PartNumber = DateTime.Now.ToString("yyyyMMdd");
                _context.Add(model.ToPartsEntity());
                _context.SaveChanges();
            }
            catch(Exception ex)
            {
                
            }
        }
        public override List<MimsCCage> GetCageInfo()
        {
           return _context.MimsCCage.ToList();
        }

        public override dynamic GetChildPartList(string parentPartId, bool exclude)
        {
            return _context.MimsCCage.ToList();
        }

        public override List<MimsXCurrency> GetCurrency()
        {
            return _context.MimsXCurrency.ToList();
        }

        public override List<MimsXGroup> GetGroupInfo()
        {
            return _context.MimsXGroup.ToList();
        }

        public override List<MimsCPartcat> GetPartsCategory()
        {
            return _context.MimsCPartcat.ToList();
        }

        public override List<MimsCParts> GetPartsList()
        {
            return _context.MimsCParts.ToList();
        }

        public override List<MimsCParttype> GetPartType()
        {
            return _context.MimsCParttype.ToList();
        }

        public override List<MimsXUom> GetUnitItems()
        {
            return _context.MimsXUom.ToList();
        }

        public override List<MimsCPartvendors> GetVendorInfo()
        {
            return _context.MimsCPartvendors.ToList();
        }

        public override List<MimsCPartvendorlist> GetVendorList()
        {
            return _context.MimsCPartvendorlist.ToList();
        }

        public override List<MimsCMcat> GetMaterialcCategoryItems() {
            return _context.MimsCMcat.ToList();
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
