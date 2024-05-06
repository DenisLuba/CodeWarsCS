using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Tests
{
    [TestFixture]
    internal class CountingDivisorsTest
    {
        [TestCase(1, 1)]
        [TestCase(4, 10)]
        [TestCase(2, 11)]
        [TestCase(8, 54)]
        public void Test(int expected, int number)
        {
            Assert.That(CountingDivisors.Divisors(number), Is.EqualTo(expected));
        }
    }
}
