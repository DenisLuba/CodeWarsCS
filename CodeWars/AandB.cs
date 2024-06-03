using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class AandB
    {
        public int Testit(int a, int b)
        {
            int aa = a, bb = b;
            while (aa > 9)
                aa = aa / 10;
            while (bb > 9)
                bb = bb / 10;

            return MathF.Abs(bb - aa) == 1 ? a + b : a * b;
        }
    }
}
