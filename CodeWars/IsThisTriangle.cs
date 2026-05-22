namespace CodeWars;

public class IsThisTriangle
{
    //public static bool IsTriangle(int a, int b, int c)
    //{
    //    if (a <= 0 && b <= 0 && c <= 0) return false;

    //    if (a >= b && a >= c) return a < b + c;
    //    if (b >= a && b >= c) return b < c + a;
    //    return a < b + c;
    //}

    public static bool IsTriangle(int a, int b, int c)
        => a + b > c
        && a + c > b
        && b + c > a
        && a > 0 && b > 0 && c > 0;
}
