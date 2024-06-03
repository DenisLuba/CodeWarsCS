using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Tests
{
    [TestFixture]
    internal class StringEndsWithTest
    {
        [TestCase("samurai", "ai", true)]
        [TestCase("sumo", "Umo", false)]
        [TestCase("nunja", "nj", false)]
        [TestCase("abc", "abc", true)]
        [TestCase("", "", true)]
        [TestCase("a", "", true)]
        [TestCase("", "a", false)]
        public void Test(string str, string ending, bool expected)
        {
            Assert.That(StringEndsWith.Solution(str, ending), Is.EqualTo(expected));
        }
    }
}
