using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars;

public class VowelRemover
{
    private static char[] chars = ['a', 'e', 'i', 'o', 'u'];

    public static string Shortcut(string input)
        => string.Concat(
            from ch in input
            where !chars.Contains(ch)
            select ch
         );
}
