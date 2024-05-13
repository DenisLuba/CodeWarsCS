using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Tests
{
    [TestFixture]
    internal class DetectPangramTest
    {
        [TestCase("The quick brown fox jumps over the lazy dog.", true)]
        public void Test(string text, bool expected)
        {
            Assert.That(DetectPangram.IsPangram(text), Is.EqualTo(expected));
        }
    }
}
