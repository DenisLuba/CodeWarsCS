namespace CodeWars
{
    public class CountingDivisors
    {
        public static int Divisors(int n) => Enumerable.Range(1, n).Count(i => n % i == 0);
    }
}
