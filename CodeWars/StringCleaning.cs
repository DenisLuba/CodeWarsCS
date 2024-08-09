using System.Linq;

namespace CodeWars;

public class StringCleaning
{
    public static string StringClean(string s)
        => string.Concat(s.Where(ch => !char.IsDigit(ch)));
}
