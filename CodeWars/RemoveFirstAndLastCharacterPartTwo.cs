namespace CodeWars;

public class RemoveFirstAndLastCharacterPartTwo
{
    public static string? Array(string s)
        => s.Count(i => i == ',') >= 2 
        ? string.Join(' ', s.Split(',')[1..^1]) 
        : null;
}
