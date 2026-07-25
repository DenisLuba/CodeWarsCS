namespace CodeWars.Tests;

[TestFixture]
public class MultiplyTheNumberTest
{
    [TestCase(10, 250)]
    [TestCase(5, 25)]
    [TestCase(200, 25000)]
    [TestCase(0, 0)]
    [TestCase(-2, -10)]
    public void SampleTest(int number, int expected)
        => Assert.That(MultiplyTheNumber.Multiply(number), Is.EqualTo(expected));
}
