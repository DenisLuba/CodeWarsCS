using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Tests
{
    [TestFixture]
    internal class CountDigitTest
    {
        [TestCase(10, 1, 4)]
        [TestCase(5750, 0, 4700)]
        [TestCase(11011, 2, 9481)]
        [TestCase(12224, 8, 7733)]
        [TestCase(11549, 1, 11905)]
        public void Test(int n, int d, int expected)
            => Assert.That(CountDigit.NoDig(n, d), Is.EqualTo(expected));
    }
}
