using System.Linq;

namespace CodeWars
{
    public class Factorial
    {
        public static int GetFactorial(int n)
            => n >= 0 && n <= 12
            ? Enumerable
            .Range(1, n > 0 ? n : 1)
            .Aggregate((n1, n2) => n1 * n2)
            : throw new ArgumentException();
    }
}
