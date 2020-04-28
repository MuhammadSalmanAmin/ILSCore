using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsHSkilledhr
    {
        public int PersonId { get; set; }
        public string SkillCode { get; set; }
        public int SkillLevel { get; set; }
    }
}
