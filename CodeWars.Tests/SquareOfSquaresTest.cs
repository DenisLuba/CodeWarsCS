using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Tests
{
    public class SquareOfSquaresTest
    {
        [TestCase(false, -1)]
        [TestCase(false, 3)]
        [TestCase(true, 4)]
        [TestCase(true, 25)]
        [TestCase(false, 26)]

        public void Test(bool expected, int num)
        {
            Assert.That(SquareOfSquares.IsSquare(num), Is.EqualTo(expected));
        }
    }
}
