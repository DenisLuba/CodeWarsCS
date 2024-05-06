using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Tests
{
    [TestFixture]
    internal class IsItEvenTest
    {
        [TestCase(true, 0)]
        [TestCase(false, 0.5)]
        [TestCase(false, 1)]
        [TestCase(true, 2)]
        [TestCase(true, -4)]

        public void Test(bool isEven, double number)
        {
            Assert.That(IsItEven.IsEven(number), Is.EqualTo(isEven));
        }
    }
}
