using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWars;

public class FindOddInt
{
    public static int FindIt(int[] sequence)
        => (from i in sequence
            group i by i into g
            where g.Count() % 2 != 0
            select g.Key).Single();

    public static int FindIt2(int[] sequence)
        => sequence
        .GroupBy(i => i)
        .Single(g => g.Count() % 2 != 0)
        .Key;

}
           
