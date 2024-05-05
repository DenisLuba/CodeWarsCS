using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Tests
{
    [TestFixture]
    internal class RemoveMinimumTest
    {
        [Test]
        public void Test()
        {
            Assert.That(RemoveMinimum.RemoveSmallest(new List<int> { 1, 2, 3, 4, 5 }), Is.EqualTo(new List<int> { 2, 3, 4, 5 }));
            Assert.That(RemoveMinimum.RemoveSmallest(new List<int> { 5, 3, 2, 1, 4 }), Is.EqualTo(new List<int> { 5, 3, 2, 4 }));
            Assert.That(RemoveMinimum.RemoveSmallest(new List<int> { 1, 2, 3, 1, 1 }), Is.EqualTo(new List<int> { 2, 3, 1, 1 }));
            Assert.That(RemoveMinimum.RemoveSmallest(new List<int>()), Is.EqualTo(new List<int>()));
        }
    }
}