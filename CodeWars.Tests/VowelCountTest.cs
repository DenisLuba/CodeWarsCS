namespace CodeWars.Tests;

[TestFixture]
public class VowelCountTest
{
    [Test]
    public void TestCase()
    {
        Assert.That(VowelCount.GetVowelCount("abracadabra"), Is.EqualTo(5), "Incorrect answer for str = \"abracadabra\"");
    }
}
