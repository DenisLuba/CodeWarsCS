namespace CodeWars;

public class AlanPartrige2
{
    public static string Apple(object n)
        => int.TryParse(n.ToString(), out var result)
        ? result * result > 1000
            ? "It's hotter than the sun!!"
            : "Help yourself to a honeycomb Yorkie for the glovebox."
        : throw new ArgumentException($"{n} is not an integer");
}
