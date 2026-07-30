namespace CodeWars.Tests;

[TestFixture]
public class RangeExtractionTest
{
    static IEnumerable<TestCaseData> CaseDatas
    {
        get
        {
            yield return new TestCaseData(new[] { -6, -3, -2, -1, 0, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20 }).Returns("-6,-3-1,3-5,7-11,14,15,17-20");
            yield return new TestCaseData(new[] { 1, 2, 3, 4, 5 }).Returns("1-5");
            yield return new TestCaseData(new[] { -3, -2, -1, 2, 10, 15, 16, 18, 19, 20 }).Returns("-3--1,2,10,15,16,18-20");
            yield return new TestCaseData(new[] { 1 }).Returns("1");
            yield return new TestCaseData(new[] { 1, 2 }).Returns("1,2");
        }
    }

    [Test, TestCaseSource(nameof(CaseDatas))]
    public string Test(int[] args) => RangeExtraction.Extract(args);
}
