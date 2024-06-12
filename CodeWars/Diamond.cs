using System.Linq;

namespace CodeWars
{
    public class Diamond
    {
        public static string? Print(int n) 
            => n > 0 && n % 2 != 0
            ? string
                .Concat((Enumerable.Range(1, n).Where(i => i % 2 != 0)).Concat(Enumerable.Range(1, n - 1).Where(i => i % 2 != 0).Reverse())
                    .Select(i => $"{new string(' ', (n - i) / 2)}{new string('*', i)}\n"))
            : null;
    }
}
