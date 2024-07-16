using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CodeWars
{
    public class SupermarketQueue
    {

        public static long QueueTime(int[] customers, int n)
        {
            int[] tills = new int[n];
            
            foreach (int time in customers)
                tills[Array.IndexOf(tills, tills.Min())] += time;
            
            return tills.Max();
        }
    }
}
