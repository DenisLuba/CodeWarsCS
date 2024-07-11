using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Tests
{
    [TestFixture]
    internal class FindOddIntTest
    {
        static IEnumerable<TestCaseData> caseDatas
        {
            get
            {
                yield return new TestCaseData(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 }).Returns(5);
                yield return new TestCaseData(new[] { 0 }).Returns(0);
                yield return new TestCaseData(new[] { 1, 2, 2, 3, 3, 3, 4, 3, 3, 3, 2, 2, 1 }).Returns(4);
            }
        }

        [Test, TestCaseSource(nameof(caseDatas))]
        public int Test(int[] sequence) => FindOddInt.FindIt(sequence);

        [Test, TestCaseSource(nameof(caseDatas))]
        public int Test2(int[] sequence) => FindOddInt.FindIt2(sequence);
    }
}
