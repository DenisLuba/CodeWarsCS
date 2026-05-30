namespace CodeWars;

public class NoOdditiesHere
{
    public static int[] NoOdds(int[] values)
        => [..values.Where(i => i % 2 == 0)];
}
