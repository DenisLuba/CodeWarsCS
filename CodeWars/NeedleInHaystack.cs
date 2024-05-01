using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class NeedleInHaystack
    {
        public static string FindNeedle(object[] haystack) 
            => $"found the needle at position {Array.IndexOf(haystack, "needle")}";
    }
}
