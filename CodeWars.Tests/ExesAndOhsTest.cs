namespace CodeWars.Tests;

[TestFixture]
internal class ExesAndOhsTest
{
    static IEnumerable<TestCaseData> testCases
    {
        get
        {
            yield return new TestCaseData("xo").Returns(true);
            yield return new TestCaseData("xxOo").Returns(true);
            yield return new TestCaseData("ooXxm").Returns(true);
            yield return new TestCaseData("zpzpzpp").Returns(true);

            yield return new TestCaseData("xxxm").Returns(false);
            yield return new TestCaseData("Oo").Returns(false);
            yield return new TestCaseData("ooom").Returns(false);

        }
    }

    [Test, TestCaseSource(nameof(testCases))]
    public bool Test(string input) => ExesAndOhs.XO(input);
}