namespace CodeWars.Tests;

[TestFixture]
public class ReversingWordsInStringTest
{
    [TestCase("Hello World!", "World! Hello")]
    [TestCase("Hi There", "There Hi")]
    [TestCase("I am testing this kata", "kata this testing am I")]
    [TestCase("I am an expert at this", "this at expert an am I")]
    public void SampleTest(string input, string expected)
        => Assert.That(ReversingWordsInString.Reverse(input), Is.EqualTo(expected));
}
