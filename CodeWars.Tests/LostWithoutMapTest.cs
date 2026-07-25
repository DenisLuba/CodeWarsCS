namespace CodeWars.Tests;

[TestFixture]
public class LostWithoutMapTest
{
    static IEnumerable<TestCaseData> caseDatas
    {
        get
        {
            yield return new TestCaseData(new[] { 1, 2, 3 }).Returns(new [] { 2, 4, 6 });
            yield return new TestCaseData(new[] { 4, 1, 1, 1, 4 }).Returns(new[] { 8, 2, 2, 2, 8 });
            yield return new TestCaseData(new[] { 2, 2, 2, 2, 2, 2 }).Returns(new[] { 4, 4, 4, 4, 4, 4 });
        }
    }

    [Test, TestCaseSource(nameof(caseDatas))]
    public int[] BasicTest(int[] cases) => LostWithoutMap.Maps(cases);
}
