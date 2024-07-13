using System.Linq;
using System;

namespace CodeWars;

public static class ReverseWords
{
    public static string GetReverseWords(string str)
        => string.Join(
            " ",
            str.Split(' ').Select(word => word.ReverseArrayFramework()));

    private static string ReverseArrayFramework(this string str)
    {
        char[] arr = str.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}
