using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Tests
{
    [TestFixture]
    internal class SumTheStringsTest
    {
        [TestCase("1", "2", "3")]
        [TestCase("", "" , "0")]
        [TestCase("ABC", "2", "2")]
        [TestCase("0", "b", "0")]
        public static void Test(string a, string b, string expected)
        {
            Assert.That(SumTheStrings.StringsSum(a, b), Is.EqualTo(expected));
        }
    }
}
