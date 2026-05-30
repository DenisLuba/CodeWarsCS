namespace CodeWars;

public class AlternateCapitalization
{
    public static string[] Capitalize(string s)
        => [
               string.Join("", s.Select((ch, i) => i % 2 == 0 ? char.ToUpper(ch) : ch)),
               string.Join("", s.Select((ch, i) => i % 2 == 1 ? char.ToUpper(ch) : ch))
           ];
}
