using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Tests
{
    [TestFixture]
    public class FiveWithoutNumbersTest
    {
        [Test]
        public void Test() => Assert.That(FiveWithoutNumbers.UnusualFive(), Is.EqualTo(5));
    }
}
