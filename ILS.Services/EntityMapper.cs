using ILS.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ILS.Services
{
    public static class EntityMapper
    {
        public static MimsCParts ToPartsEntity(this AddPartViewModel model)
        {
            MimsCParts entity = new MimsCParts()
            {
                //Ac = !String.IsNullOrEmpty(model.AC) ? Convert.ToInt32(model.AC): 0,
                //Anc = !String.IsNullOrEmpty(model.ANC) ? Convert.ToInt32(model.ANC) : 0,
                //Ap = !String.IsNullOrEmpty(model.AP) ? Convert.ToInt32(model.AP) : 0,
                //App= !String.IsNullOrEmpty(model.APP) ? Convert.ToInt32(model.APP) : 0,
                //Asc = !String.IsNullOrEmpty(model.ASC) ? Convert.ToInt32(model.ASC) : 0,
                Brf = model.BRF,
                //Currency = !String.IsNullOrEmpty(model.Currency) ? Convert.ToInt32(model.Currency) : 0,
                //CustodyId = !String.IsNullOrEmpty(model.CustodyId) ? Convert.ToInt32(model.CustodyId) : 0,
                DateAdded = model.CreationDateTime,
                DateUpdated  = model.ModifiedDateTime,
               // DerivativeId = !String.IsNullOrEmpty(model.Derivative) ? Convert.ToInt32(model.Derivative) : 0,
                Diameter = Convert.ToSingle(model.Diameter),
                Height = model.Height,
               //HZECode = !String.IsNullOrEmpty(model.HZECode) ? Convert.ToInt32(model.HZECode) : 0,
               // LeadTimeId = !String.IsNullOrEmpty(model.LeadTime) ? Convert.ToInt32(model.LeadTime) : 0,
                Length = model.Length,
                ManId = !String.IsNullOrEmpty(model.ManufacturerId) ? long.Parse(model.ManufacturerId) : 0,
                Mcat = model.MaterialCategoryId,
                Mtbf = model.MTBF,
                Mmtr = model.MMTR,
                OldNsn = model.OldNSN,
            //    OldSmic = !String.IsNullOrEmpty(model.OldSMIC) ? Convert.ToInt32(model.OldSMIC) : 0,
              //  Osi = !String.IsNullOrEmpty(model.OSI) ? Convert.ToInt32(model.OSI) : 0,
                PartCat = model.PartCategoryId,
                PartCharacteristics=model.PartCharacteristics,
                PartCode = string.Empty,
                PartType = model.PartTypeId,
                PartNo = model.PartNumber,
                PartName = model.PartName,
                PictureFileName = model.PictureFileName
            };

            return entity;
        }
    }
}
