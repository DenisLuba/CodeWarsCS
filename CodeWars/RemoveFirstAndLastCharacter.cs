using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class RemoveFirstAndLastCharacter
    {
        //public static string Remove_char(string s) => string.Concat(s.Skip(1).SkipLast(1));
        public static string Remove_char(string s) => s[1..^1];
    }
}
