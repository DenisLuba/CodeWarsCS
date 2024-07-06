namespace CodeWars;

public class BasicMathematicalOperations
{
    public static double BasicOp(char operation, double value1, double value2) => operation switch
    {
        '+' => value1 + value2,
        '-' => value1 - value2,
        '*' => value1 * value2,
        '/' => value1 / value2,
        _ => throw new ArgumentException("Unknown operation", $"{operation}")
    };
}
