using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace CodeWars
{
    public class TotalAmountOfPoints
    {
        public static int TotalPoints(string[] games) => games.Sum(s => s[0] < s[2] ? 0 : s[0] > s[2] ? 3 : 1);
        //    public static int TotalPoints(string[] games)
        //        => games
        //            .Select(s => GetPoint(s.Split(":"))).Sum();

        //    private static int GetPoint(string[] points)
        //    {
        //        var different = points.Select(int.Parse).Aggregate((x, y) => x - y);
        //        if (different > 0)
        //            return 3;
        //        else if (different == 0)
        //            return 1;
        //        else
        //            return 0;
        //    }
    }
}
