using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Tests
{
    [TestFixture]
    internal class RemoveAnchorFromURLTest
    {
        [TestCase("", "")]
        public void Test(string url, string expected)
        {
            Assert.That(RemoveAnchorFromURL.RemoveUrlAnchor("www.codewars.com#about"), Is.EqualTo("www.codewars.com"));
            Assert.That(RemoveAnchorFromURL.RemoveUrlAnchor("www.codewars.com/katas/?page=1#about"), Is.EqualTo("www.codewars.com/katas/?page=1"));
            Assert.That(RemoveAnchorFromURL.RemoveUrlAnchor("www.codewars.com/katas/"), Is.EqualTo("www.codewars.com/katas/"));
        }
    }
}
