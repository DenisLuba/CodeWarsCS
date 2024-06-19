using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Tests
{
    internal class UniqueInOrderTest
    {
        [Test]
        public void EmptyTest()
        {
            Assert.That(UniqueInOrder.UniqueInOrderMethod(""), Is.EqualTo(""));
        }
        [Test]
        public void Test1()
        {
            Assert.That(UniqueInOrder.UniqueInOrderMethod("AAAABBBCCDAABBB"), Is.EqualTo("ABCDAB"));
        }
    }
}
