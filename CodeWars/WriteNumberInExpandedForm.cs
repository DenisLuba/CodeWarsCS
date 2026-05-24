namespace CodeWars;

public class WriteNumberInExpandedForm
{
    //public static string ExpandedForm(long num)
    //{
    //    var nums = new LinkedList<long>();

    //    for (int i = 10; i <= num; i *= 10)
    //    {
    //        var d = num % i;
    //        if (d == 0) continue;

    //        nums.AddFirst(d);
    //        num -= d;
    //    }

    //    nums.AddFirst(num);

    //    return string.Join(" + ", nums);
    //}

    public static string ExpandedForm(long num)
        => string.Join(" + ",
            num
            .ToString()
            .Reverse()
            .Select((item, index) => item + new string('0', index))
            .Where(i => i.Length > i.Count(i => i == '0'))
            .Reverse());
}
