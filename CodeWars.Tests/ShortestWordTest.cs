using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Tests
{
    internal class ShortestWordTest
    {
        [TestCase("bitcoin take over the world maybe who knows perhaps", 3)]
        [TestCase("turns out random test cases are easier than writing out basic ones", 3)]
        [TestCase("Let's travel abroad shall we", 2)]
        public void Test(string input, int expected)
        {
            Assert.That(ShortestWord.FindShort(input), Is.EqualTo(expected));
        }
    }
}
