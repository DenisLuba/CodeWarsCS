namespace CodeWars
{
    public class PositivesCountNegativesSum
    {
        public static int[] CountPositivesSumNegatives(int[] input)
            => input is not null && input.Count() != 0
            ? [input.Count(i => i > 0), input.Where(i => i < 0).Sum()]
            : [];
    }
}
