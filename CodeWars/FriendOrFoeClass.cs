using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class FriendOrFoeClass
    {
        public static IEnumerable<string> FriendOrFoe(string[] names) => names.Where(s => s.Length == 4);
    }
}
