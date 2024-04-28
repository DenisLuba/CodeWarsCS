using System.Linq;

namespace CodeWars
{
    public class NumbersSum
    {
        public static int GetSum(int a, int b)
            => Enumerable.Range(Math.Min(a, b), Math.Abs(a - b) + 1).Sum();
    }
}
