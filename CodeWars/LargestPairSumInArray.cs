namespace CodeWars;

public class LargestPairSumInArray
{
    public static int LargestPairSum(int[] numbers)
        => numbers.OrderByDescending(x => x)
            .Take(2)
            .Sum();

    public static int FastestLargestPairSum(int[] numbers)
    {
        var max1 = int.MinValue;
        var max2 = int.MinValue;

        foreach(var x in numbers)
        {
            if (x > max1)
            {
                max2 = max1;
                max1 = x;
            }
            else if (x > max2)
            {
                max2 = x;
            }
        }

        return max1 + max2;
    }
}
