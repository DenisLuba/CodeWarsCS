using System.Linq;

namespace CodeWars;

public class CountingSheep
{
    public static int CountSheeps(bool[] sheeps) => sheeps.Count(x => x);
}
