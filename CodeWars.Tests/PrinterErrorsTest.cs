using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Tests
{
    [TestFixture]
    internal class PrinterErrorsTest
    {
        [TestCase("aaabbbbhaijjjm", "0/14")]
        [TestCase("aaaxbbbbyyhwawiwjjjwwm", "8/22")]
        [TestCase("aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz", "3/56")]
        public void Test(string input, string expected)
        {
            Assert.That(PrinterErrors.PrinterError(input), Is.EqualTo(expected));
        }
    }
}
