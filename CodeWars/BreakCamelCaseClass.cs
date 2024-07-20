using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars;

public class BreakCamelCaseClass
{
    public static string BreakCamelCase(string str) => str
        .Aggregate("", (ch1, ch2) => char.IsUpper(ch2) ? $"{ch1} {ch2}" : $"{ch1}{ch2}");
}
