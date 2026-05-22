namespace CodeWars;

public class SumOfMultiples
{
    //public static int SumMul(int n, int m)
    //{

    //    try
    //    {
    //        return Enumerable.Range(n, m - n).Where(i => i % n == 0).Sum();
    //    }
    //    catch (Exception)
    //    {
    //        throw new ArgumentException();
    //    }
    //}

    public static int SumMul(int n, int m)
        => n > 0 && m > n 
        ? Enumerable.Range(n, m - n).Where(i => i % n == 0).Sum() 
        : throw new ArgumentException();
}
