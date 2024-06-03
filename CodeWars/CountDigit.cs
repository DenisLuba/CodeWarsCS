using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class CountDigit
    {
        public static int NoDig(int n, int d) => string.Concat(Enumerable
                .Range(0, n + 1)
                .Select(i => i * i)
                .Where(i => i.ToString().Contains(d.ToString()))
                .Select(i => new Regex(@$"[^{d}]").Replace(i.ToString(), ""))
            ).Length;
    }
}
