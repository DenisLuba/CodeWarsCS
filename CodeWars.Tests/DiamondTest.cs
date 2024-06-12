using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Tests
{
    [TestFixture]
    internal class DiamondTest
    {
        [TestCase(5, "  *\n ***\n*****\n ***\n  *\n")]
        [TestCase(3, " *\n***\n *\n")]
        [TestCase(1, "*\n")]
        // Tests null
        [TestCase(-1, null)]
        [TestCase(0, null)]
        [TestCase(2, null)]

        public void Test(int n, string? expected)
            => Assert.That(Diamond.Print(n), Is.EqualTo(expected));
        
    }
}
