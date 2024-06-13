using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class CuboidsVolumesDifference
    {
        public static int FindDifference(int[] a, int[] b) => Math.Abs(a.Product() - b.Product());
    }

    static class ArrayExtension
    {
        public static int Product(this int[] cuboid) => cuboid.Aggregate((x, y) => x * y);
    }
}
