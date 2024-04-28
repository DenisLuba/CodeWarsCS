using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Tests
{
    [TestFixture]
    internal class NumbersSumTest
    {
        [TestCase(1, 0, 1)]
        [TestCase(1, 2, 3)]
        [TestCase(0, 1, 1)]
        [TestCase(1, 1, 1)]
        [TestCase(-1, 0, -1)]
        [TestCase(-1, 2, 2)]
        public void Test(int start, int end, int expected)
        {
            Assert.That(NumbersSum.GetSum(start, end), Is.EqualTo(expected));
        }
    }
}
