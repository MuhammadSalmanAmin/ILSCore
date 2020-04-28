using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsATcommand
    {
        public int? TypeCommand { get; set; }
        public string TypeCommandName { get; set; }
        public int? Command { get; set; }
    }
}
