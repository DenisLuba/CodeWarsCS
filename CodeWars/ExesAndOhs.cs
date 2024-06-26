namespace CodeWars;

public class ExesAndOhs
{
    public static bool XO(string input) => input
        .ToLower()
        .Sum(ch => ch == 'x' ? 1 : ch == 'o' ? -1 : 0) == 0;
}

