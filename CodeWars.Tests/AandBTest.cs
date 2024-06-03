using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Tests
{
    [TestFixture]
    internal class AandBTest
    {
        //a+b?
        [TestCase(0, 1, 1)]
        [TestCase(1, 2, 3)]
        [TestCase(10, 20, 30)]
        //a*b?
        [TestCase(1, 1, 1)]
        [TestCase(1, 3, 3)]
        public void Test(int a, int b, int expected)
        {
            Assert.That(new AandB().Testit(a, b), Is.EqualTo(expected));
        }
    }
}
