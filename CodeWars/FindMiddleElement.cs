using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class FindMiddleElement
    {
        public static int Gimme2(double[] inputArray)
            => 3 - Array.IndexOf<double>(inputArray, inputArray.Max()) - Array.IndexOf(inputArray, inputArray.Min());

        public static int Gimme(double[] inputArray)
            => Array.IndexOf(inputArray, inputArray.OrderBy(i => i).ToArray()[1]);
    }
}
