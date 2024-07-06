using System.Collections.Generic;
using System.Linq;

namespace CodeWars;

public class CountByX
{
    public static int[] CountBy(int x, int n) => Enumerable.Range(1, n).Select(i => i * x).ToArray();
}
