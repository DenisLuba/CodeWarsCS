using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class RemoveMinimum
    {
        public static List<int> RemoveSmallest(List<int> numbers)

        {
            if (!numbers.Any()) return numbers;
            var result = new List<int>(numbers);
            result.Remove(result.Min());
            return result ;
        }
    }
}
