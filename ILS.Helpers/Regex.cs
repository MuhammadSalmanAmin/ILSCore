using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILS.Helpers
{
    public static class Regex
    {
        public const string NumbersOnly = @"[0-9]+$";
        public const string AlphabetsOnly = @"[a-zA-Z]+$";
        public const string AlphabetsWithSpaces= @"[a-zA-Z ]+$";
        public const string AlphanumericOnly = @"[a-zA-Z][a-zA-Z0-9]*$";
        public const string DecimalWithTwoPrecision = @"[0-9]+([.][0-9]{1,2})";
    }
}
