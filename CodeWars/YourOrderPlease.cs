using System.Text.RegularExpressions;

namespace CodeWars
{
    public class YourOrderPlease
    {
        public static string Order(string words)
            => string.Join(" ", words.Split(" ").OrderBy(w => Regex.Replace(w, @"\D", "")));
    }
}
