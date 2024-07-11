using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Tests
{
    [TestFixture]
    internal class VowelRemoverTest
    {
        [TestCase("hello", "hll")]
        [TestCase("codewars", "cdwrs")]
        [TestCase("goodbye", "gdby")]
        [TestCase("HELLO", "HELLO")]
        public void Test(string input, string expected)
            => Assert.That(VowelRemover.Shortcut(input), Is.EqualTo(expected));
    }
}
