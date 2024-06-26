namespace CodeWars.Tests;

[TestFixture]
internal class PersonalizedMessageTest
{
    [TestCase("Hello boss", "Daniel", "Daniel")]
    [TestCase("Hello guest", "Greg", "Daniel")]
    public void Test(string expected, string name, string owner) 
        => Assert.That(PersonalizedMessage.Greet(name, owner), Is.EqualTo(expected));
}
