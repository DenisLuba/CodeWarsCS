namespace CodeWars;

public partial class TitleCase
{
    public static string GetTitleCase(string title, string minorWords = "")
    {
        var minorWordsSet = minorWords.Split().ToHashSet(StringComparer.OrdinalIgnoreCase);

        return string.Join(" ", title.Split()
            .Select((word, i) =>
                i == 0 || !minorWordsSet.Contains(word, StringComparer.OrdinalIgnoreCase)
                ? word.Length < 2 ? word.ToUpper() : char.ToUpper(word[0]) + word[1..].ToLower()
                : word.ToLower()));
    }
}
