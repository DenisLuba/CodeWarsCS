namespace CodeWars;

public class SortedYesNoHow
{
    public static string IsSortedAndHow(int[] array)
        => array.Zip(array.Skip(1), (a, b) => b - a).All(i => i >= 0) ? "yes, ascending"
        : array.Zip(array.Skip(1), (a, b) => b - a).All(i => i <= 0) ? "yes, descending"
        : "no";
}
