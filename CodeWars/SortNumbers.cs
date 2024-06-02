using System.Linq;

namespace CodeWars
{
    public class SortNumbers
    {
        public static int[] SortNums(int[]? numbers)
            => numbers == null
                ? new int[] { }
                : numbers.OrderBy(x => x).ToArray();
    }
}
