using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Tests
{
    [TestFixture]
    internal class ReverseWordsTest
    {
        [TestCase("", "")]
        [TestCase("hello", "olleh")]
        [TestCase("This is an example!", "sihT si na !elpmaxe")]
        public void Test(string input, string expected)
            => Assert.That(ReverseWords.GetReverseWords(input), Is.EqualTo(expected));
    }
}
