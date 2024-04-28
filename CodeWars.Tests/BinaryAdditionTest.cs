using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Tests
{
    [TestFixture]
    internal class BinaryAdditionTest
    {
        [TestCase("11", 1, 2)]
        [TestCase("10", 0, 2)]
        [TestCase("101", 3, 2)]
        public void Test(string expected, int num_1, int num_2)
        {
            Assert.That(BinaryAddition.AddBinary(num_1, num_2), Is.EqualTo(expected));
        }
    }
}
