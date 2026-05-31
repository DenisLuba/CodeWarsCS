namespace CodeWars;

public class HowManyStairsWillSuzukiClimbIn20Years
{
    public static long StairsIn20(int[][] stairs)
        => stairs.Sum(s => s.Sum()) * 20;
}
