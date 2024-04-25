using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class Isograms
    {
        public static bool IsIsogram(string str) => str.Length == str.ToLower().Distinct().Count();
    }
}
