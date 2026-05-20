using System.ComponentModel;
using System.Xml;

namespace CodeWars;

public class FindUniqueNumber
{
    //public static int GetUnique(IEnumerable<int> numbers)
    //    => numbers
    //    .GroupBy(i => i)
    //    .FirstOrDefault(g => g.Count() == 1)?
    //    .Key
    //    ?? 0;

    // faster
    public static int GetUnique(IEnumerable<int> numbers)
    {
        var unique = new HashSet<int>();
        var duplicates = new HashSet<int>();

        foreach (var number in numbers)
        {
            // if duplicates already contains a number, we continue
            if (duplicates.Contains(number)) continue;

            // if unique contains a number, 
            // we get the false value and add it to duplicates 
            // and remove it from unique
            if (!unique.Add(number))
            {
                unique.Remove(number);
                duplicates.Add(number);
            }
        }
        return unique.FirstOrDefault();
    }
}
