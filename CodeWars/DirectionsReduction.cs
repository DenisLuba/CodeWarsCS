using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars;

public static class DirectionsReduction
{
    public static string[] DirReduction(string[] arr)
    {
        var list = new List<string>();
        foreach (var direction in arr)
        {
            if (list.Count > 0 && NeedRemove(list.Last(), direction))
                list.RemoveAt(list.Count - 1);
            else list.Add(direction);
        }
        return list.ToArray();
    }

    // ******************************************

    private static bool NeedRemove(string first, string second)
        => first.GetInt() + second.GetInt() == 0;

    static int GetInt(this string direction) 
        => direction != "" 
        ? (int) Enum.Parse(typeof(Direction), direction, true)
        : -10;

    private enum Direction
    {
        NORTH = -1,
        SOUTH = 1,
        WEST = -2,
        EAST = 2
    }
}
