namespace CodeWars;

public class VowelCode
{
    public static string Encode(string msg)
        => msg.Replace('a', '1')
              .Replace('e', '2')
              .Replace('i', '3')
              .Replace('o', '4')
              .Replace('u', '5');

    public static string Decode(string msg)
        => msg.Replace('1', 'a')
              .Replace('2', 'e')
              .Replace('3', 'i')
              .Replace('4', 'o')
              .Replace('5', 'u');
}
