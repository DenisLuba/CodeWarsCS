using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Tests
{
    internal class SupermarketQueueTest
    {
        [TestCase(new int[] { }, 1, 0)]
        [TestCase(new[] { 1, 2, 3, 4 }, 1, 10)]
        [TestCase(new[] { 2, 2, 3, 3, 4, 4 }, 2, 9)]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, 100, 5)]
        public void Test(int[] customers, int n, long expected)
            => Assert.That(SupermarketQueue.QueueTime(customers, n), Is.EqualTo(expected));
    }
}
