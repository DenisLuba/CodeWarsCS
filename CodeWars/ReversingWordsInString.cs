namespace CodeWars;

public class ReversingWordsInString
{
    public static string Reverse(string text)
        => string.Join(' ', text.Split(' ').Reverse());
}
