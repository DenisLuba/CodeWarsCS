namespace CodeWars;

public class FindRemainder
{
    public static int Remainder(int a, int b)
        => a >= b ? a % b : b % a;
}
