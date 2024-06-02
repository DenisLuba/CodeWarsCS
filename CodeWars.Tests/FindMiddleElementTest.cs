using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Tests
{
    [TestFixture]
    internal class FindMiddleElementTest
    {
        [Test]
        public void Test()
        {
            Assert.That(FindMiddleElement.Gimme(new double[] { 2, 3, 1 }), Is.EqualTo(0));
            Assert.That(FindMiddleElement.Gimme(new double[] { 5, 10, 14 }), Is.EqualTo(1));
        }
    }
}
