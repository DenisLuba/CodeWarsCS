namespace CodeWars;

public class SumDigPower
{
    private static Predicate<long> AreEqual = x => x == x.SumDigitsPowers();

    public static long[] SumDigPow(long a, long b) 
        => (a, b).Range()
            .Where(x => AreEqual(x))
            .ToArray();

}

public static class LongExtensions
{
    public static IEnumerable<long> Range(this (long a, long b) range)
    {
        if (range.a > range.b)
            (range.a, range.b) = (range.b, range.a);

        for (var i = range.a; i < range.b; i++)
            yield return i;
    }

    public static long SumDigitsPowers(this long a)
        => a.ToString()
            .Select((n, i) => (long)Math.Pow(int.Parse(n.ToString()), i + 1))
            .Sum();
}

