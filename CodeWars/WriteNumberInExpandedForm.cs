namespace CodeWars;

public class WriteNumberInExpandedForm
{
    public static string ExpandedForm(long num)
        => string.Join(" + ",
            num
            .ToString()
            .Reverse()
            .Select((item, index) => item + new string('0', index))
            .Where(i => i.Length > i.Count(i => i == '0'))
            .Reverse());
}
