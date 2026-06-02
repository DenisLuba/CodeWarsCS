namespace CodeWars.Tests;

[TestFixture]
public class TitleCaseTest
{
    [TestCase("a clash of KINGS", "a an the of", "A Clash of Kings")]
    [TestCase("THE WIND IN THE WILLOWS", "The In", "The Wind in the Willows")]
    [Order(1)]
    public void MyTest(string sampleTitle, string sampleMinorWords, string expected)
    {
        Assert.That(TitleCase.GetTitleCase(sampleTitle, sampleMinorWords), Is.EqualTo(expected));
    }
}
