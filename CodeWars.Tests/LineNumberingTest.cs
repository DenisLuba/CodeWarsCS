using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Tests
{
    [TestFixture]
    internal class LineNumberingTest
    {
        [TestCase]
        public void Test()
        {
            Assert.That(LineNumbering.Number(new List<string>()), Is.EqualTo(new List<string>()));
            Assert.That(LineNumbering.Number(new List<string> { "a", "b", "c" }), Is.EqualTo(new List<string> { "1: a", "2: b", "3: c" }));
            Assert.That(LineNumbering.Number(new List<string> { "", "", "", "", "" }), Is.EqualTo(new List<string> { "1: ", "2: ", "3: ", "4: ", "5: " }));
        }
    }
}
