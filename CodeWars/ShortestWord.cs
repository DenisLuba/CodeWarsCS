using System.Linq;

namespace CodeWars
{
    public class ShortestWord
    {
        public static int FindShort(string s) 
            => s.Split(" ").Min(w => w.Length);
    }
}
