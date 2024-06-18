using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class AnagramDetection
    {
        public static bool IsAnagram(string test, string original)
        {
            return test.ToLower().OrderBy(x => x).SequenceEqual(original.ToLower().OrderBy(x => x));

            //original = original.ToLower();

            //bool result = test.ToLower().All(ch =>
            //{
            //    if (original.Contains(ch))
            //    {
            //        original = original.Remove(original.IndexOf(ch), 1);
            //        return true;
            //    }
            //    return false;
            //});

            //return result && original.Length == 0;
        }
    }
}
