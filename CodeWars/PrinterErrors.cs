using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class PrinterErrors
    {
        public static string PrinterError(String s)
            => $"{s.Where(ch => ch > 'm').Count()}/{s.Length}";
    }
}
