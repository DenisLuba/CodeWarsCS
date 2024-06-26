namespace CodeWars.Tests
{
    internal class PositivesCountNegativesSumTest
    {
        static IEnumerable<TestCaseData> TestCases
        {
            get
            {
                yield return new TestCaseData(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 })
                    .Returns(new[] { 10, -65 });

                yield return new TestCaseData(new[] { 0, 2, 3, 0, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14 })
                    .Returns(new[] { 8, -50 });

                yield return new TestCaseData(new int[] { })
                    .Returns(new int[] { });

                yield return new TestCaseData(null).Returns(new int[] { });
            }
        }

        [Test, TestCaseSource(nameof(TestCases))]
        public int[] Test(int[] input) => PositivesCountNegativesSum.CountPositivesSumNegatives(input);
    }
}
