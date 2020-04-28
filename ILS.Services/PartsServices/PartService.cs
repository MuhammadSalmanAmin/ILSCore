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
            catch (Exception ex)
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

        public override List<MimsXMec> GetMECInfo()
        {
            return _context.MimsXMec.ToList();
        }

        public override List<MimsXAp> GetAPItemsList()
        {
            return _context.MimsXAp.ToList();
        }

        public override List<MimsXAc> GetACItemsList()
        {
            return _context.MimsXAc.ToList();
        }

        public override List<MimsXAsc> GetASCItemsList()
        {
            return _context.MimsXAsc.ToList();
        }

        public override List<MimsXAnc> GetANCInfo()
        {
            return _context.MimsXAnc.ToList();
        }

        public override List<MimsXApp> GetAPPInfo()
        {
            return _context.MimsXApp.ToList();
        }

        public override List<MimsXCustody> GetCustodyInfo()
        {
            return _context.MimsXCustody.ToList();
        }

        public override List<MimsXSmc> GetSMCInfo()
        {
            return _context.MimsXSmc.ToList();
        }

        public override List<MimsXShelflife> GetShelfLifeItems()
        {
            return _context.MimsXShelflife.ToList();
        }

        public override List<MimsXDerivative> GetDerivativeItems()
        {
            return _context.MimsXDerivative.ToList();
        }

        public override List<MimsXSmic> GetSMICItems()
        {
            return _context.MimsXSmic.ToList();
        }

        public override List<MimsXTimeperiod> GetLeadTimeItems()
        {
            return _context.MimsXTimeperiod.ToList();
        }

        public override List<MimsXTss> GetTSSItems()
        {
            return _context.MimsXTss.ToList();
        }

        public override List<MimsXOsi> GetOSIItems()
        {
            return _context.MimsXOsi.ToList();
        }

        public override List<MimsXUom> GetUnitCubeItems()
        {
            return _context.MimsXUom.ToList();
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
