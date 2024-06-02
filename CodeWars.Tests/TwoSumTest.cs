using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Tests
{
    [TestFixture]
    internal class TwoSumTest
    {
        [Test]
        public void Test()
        {
            Assert.That(TwoSumClass.TwoSum(new[] { 1, 2, 3 }, 4).OrderBy(a => a).ToArray(), Is.EqualTo(new[] { 0, 2 }));
            Assert.That(TwoSumClass.TwoSum(new[] { 1234, 5678, 9012 }, 14690).OrderBy(a => a).ToArray(), Is.EqualTo(new[] { 1, 2 }));
            Assert.That(TwoSumClass.TwoSum(new[] { 2, 2, 3 }, 4).OrderBy(a => a).ToArray(), Is.EqualTo(new[] { 0, 1 }));
        }
    }
}
