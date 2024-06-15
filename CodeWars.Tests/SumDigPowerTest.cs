namespace CodeWars.Tests
{
    [TestFixture]
    internal class SumDigPowerTest
    {
        private static IEnumerable<TestCaseData> TestCases
        {
            get
            {
                yield return new TestCaseData(1, 10).Returns(new long[] {1, 2, 3, 4, 5, 6, 7, 8, 9 });
                yield return new TestCaseData(1, 100).Returns(new long[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 89 });
                yield return new TestCaseData(10, 100).Returns(new long[] { 89 });
                yield return new TestCaseData(90, 100).Returns(new long[] { });
                yield return new TestCaseData(90, 150).Returns(new long[] { 135 });
                yield return new TestCaseData(50, 150).Returns(new long[] { 89, 135 });
                yield return new TestCaseData(10, 150).Returns(new long[] { 89, 135 });
                yield return new TestCaseData(150, 10).Returns(new long[] { 89, 135 });
            }
        }

        [Test, TestCaseSource(nameof(TestCases))]
        public long[] Test(long a, long b) => SumDigPower.SumDigPow(a, b);
    }
}
