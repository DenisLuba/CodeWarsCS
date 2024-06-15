using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Tests
{
    [TestFixture]
    internal class WelcomeTest
    {
        [TestCase("englich", "Welcome")]
        [TestCase("dutch", "Welkom")]
        [TestCase("IP_ADDRESS_INVALID", "Welcome")]
        [TestCase("", "Welcome")]
        [TestCase("2", "Welcome")]
        public void Test(string language, string expected)
            => Assert.That(Welcome.Greet(language), Is.EqualTo(expected));
    }
}
