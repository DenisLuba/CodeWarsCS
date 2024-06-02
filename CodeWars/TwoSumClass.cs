using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class TwoSumClass
    {
        public static int[] TwoSum(int[] numbers, int target)
        => numbers
            .Select((a, i) => numbers[(i + 1)..^0].Select((k, j) => a + k == target ? new int[] { i, i + j + 1 } : null).Where(a => a != null).FirstOrDefault() ?? null)
            .Where(a => a != null)
            .FirstOrDefault() ?? new int[2];
    }
}
