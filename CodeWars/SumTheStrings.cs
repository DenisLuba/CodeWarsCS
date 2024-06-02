using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class SumTheStrings
    {
        public static string StringsSum(string a, string b)
            => ((int.TryParse(a, out int numberA) ? numberA : 0) + (int.TryParse(b, out int numberB) ? numberB : 0)).ToString();
    }
}
