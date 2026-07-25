namespace CodeWars;

public class MultiplyTheNumber
{
    public static int Multiply(int number)
        => (int)Math.Pow(5, $"{number}".Replace("-", "").Length) * number;
}
