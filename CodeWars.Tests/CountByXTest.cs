namespace CodeWars.Tests;

internal class CountByXTest
{
    private static IEnumerable<TestCaseData> testCases
    {
        get
        {
            yield return new TestCaseData(1, 10).Returns(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            yield return new TestCaseData(2, 5).Returns(new int[] { 2, 4, 6, 8, 10 });
        }
    }

    [Test, TestCaseSource(nameof(testCases))]
    public static int[] Test(int x, int n) => CountByX.CountBy(x, n);
}
