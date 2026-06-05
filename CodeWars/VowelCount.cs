namespace CodeWars;

public class VowelCount
{
    public static int GetVowelCount(string str)
        => str.Count(c => "aeiouAEIOU".Contains(c));
}
