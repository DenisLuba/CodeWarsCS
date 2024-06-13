using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Tests
{
    [TestFixture]
    internal class CuboidsVolumesDifferenceTest
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData(new[] { 3, 2, 5 }, new[] { 1, 4, 4 }).Returns(14);
                yield return new TestCaseData(new[] { 9, 7, 2 }, new[] { 5, 2, 2 }).Returns(106);
                yield return new TestCaseData(new[] { 11, 2, 5 }, new[] { 1, 10, 8 }).Returns(30);
                yield return new TestCaseData(new[] { 4, 4, 7 }, new[] { 3, 9, 3 }).Returns(31);
                yield return new TestCaseData(new[] { 15, 20, 25 }, new[] { 10, 30, 25 }).Returns(0);
            }
        }

        [Test, TestCaseSource(nameof(testCases))]
        public int Test(int[] a, int[] b) => CuboidsVolumesDifference.FindDifference(a, b);
    }
}
