using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class LineNumbering
    {
        public static List<string> Number(List<string> lines)
            => lines.Select((line, i) => $"{++i}: {line}").ToList();
    }
}
