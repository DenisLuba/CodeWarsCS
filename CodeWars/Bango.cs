using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class Bango
    {
        public static string AreYouPlayingBanjo(string name)
            => name.ToLower().StartsWith('r') ? $"{name} plays banjo" : $"{name} does not play banjo";
    }
}
