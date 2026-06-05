namespace CodeWars.Tests;

[TestFixture]
public class ParseNiceIntFromCharProblemTest
{
    [Test]
    public void BasicTests()
    {
        Assert.Multiple(() =>
        {
            Assert.That(ParseNiceIntFromCharProblem.GetAge("3 years old"), Is.EqualTo(3));
            Assert.That(ParseNiceIntFromCharProblem.GetAge("4 years old"), Is.EqualTo(4));
            Assert.That(ParseNiceIntFromCharProblem.GetAge("9 years old"), Is.EqualTo(9));
        });
    }
}
