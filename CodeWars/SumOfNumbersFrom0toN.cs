namespace CodeWars;

public class SumOfNumbersFrom0toN
{
    public static string ShowSequence(int n)
        => n switch
        {
            < 0 => $"{n}<0",
            0 => "0=0",
            _ => new Func<string>(() => {
                var range = Enumerable.Range(0, n + 1);
                return $"{string.Join("+", range)} = {range.Sum()}";
            })()
        };

        //=> n < 0
        //? $"{n}<0"
        //: n == 0
        //    ? "0=0"
        //    : $"{string.Join("+", Enumerable.Range(0, n + 1))} = {Enumerable.Range(0, n + 1).Sum()}";
}
