using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class ListFiltering
    {
        //public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems) => listOfItems.Where(i => i is int).Select(i => (int) i);
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems) => listOfItems.OfType<int>();
    }
}
 