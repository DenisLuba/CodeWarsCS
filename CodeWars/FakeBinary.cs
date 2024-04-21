using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class FakeBinary
    {
        public static string FakeBin(string x) => string.Concat(x.Select(ch => ch < '5' ? '0' : '1'));
    }
}
