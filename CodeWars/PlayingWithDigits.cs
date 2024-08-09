using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class PlayingWithDigits
    {
        public static long DigPow(int n, int p)
        {
            var result = n
                .ToString()
                .Select((x, i) => Math.Pow(Convert.ToInt32(x), i + p - 1))
                .Sum() / n;

            return result % 1 == 0 ? (long) result : -1;
        }
    }
}
