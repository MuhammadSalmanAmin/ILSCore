using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsMDoccat
    {
        public MimsMDoccat()
        {
            MimsMTaskmaster = new HashSet<MimsMTaskmaster>();
        }

        public string CatId { get; set; }
        public string CatName { get; set; }

        public virtual ICollection<MimsMTaskmaster> MimsMTaskmaster { get; set; }
    }
}
