namespace CodeWars;

public class ConsonantValue
{
    public static int Solve(string s)
        => s
        .Split('a', 'e', 'i', 'o', 'u')
        .Max(sub => sub.Sum(ch => ch - 'a' + 1));
}
