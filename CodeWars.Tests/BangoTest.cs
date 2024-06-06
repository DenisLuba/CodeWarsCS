using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Tests
{
    [TestFixture]
    internal class BangoTest
    {
        [TestCase("Martin", "Martin does not play banjo")]
        [TestCase("Rikke", "Rikke plays banjo")]
        [TestCase("rolf", "rolf plays banjo")]
        public void Test(string name, string expected)
        {
            Assert.That(Bango.AreYouPlayingBanjo(name), Is.EqualTo(expected));
        }
    }
}
