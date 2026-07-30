using System.Text;
using System.Collections.Generic;

namespace CodeWars;

public class RangeExtraction
{
    public static string Extract(int[] args)
    {
        var result = new List<string>();
        int startRange, endRange, i, j;

        for (i = 0; i < args.Length;)
        {
            startRange = args[i];
            endRange = startRange;

            for (j = i + 1; j < args.Length; j++)
            {
                if (args[j] - args[j - 1] > 1)
                    break;

                endRange = args[j];
            }

            var range = (endRange - startRange) switch
            {
                0 => $"{startRange}",
                1 => $"{startRange},{endRange}",
                _ => $"{startRange}-{endRange}"
            };

            result.Add(range);
            i = j;
        }

        return string.Join(',', result);
    }
}
