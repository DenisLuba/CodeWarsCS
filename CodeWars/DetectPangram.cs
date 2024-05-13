using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class DetectPangram
    {
        public static bool IsPangram(string str) 
            => Enumerable
            .Range('a', 'z' - 'a' + 1)
            .All(ch => str.ToLower().Contains((char)ch));
    }
}
