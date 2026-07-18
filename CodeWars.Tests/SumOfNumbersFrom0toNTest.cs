namespace CodeWars.Tests;

[TestFixture]
public class SumOfNumbersFrom0toNTest
{
    [TestCase(0, "0=0")]
    [TestCase(5, "0+1+2+3+4+5 = 15")]
    [TestCase(-1, "-1<0")]
    [TestCase(2, "0+1+2 = 3")]
    [TestCase(3, "0+1+2+3 = 6")]
    [TestCase(4, "0+1+2+3+4 = 10")]
    public void SequenceSumTest(int input, string expected)
    {
        Assert.That(expected, Is.EqualTo(SumOfNumbersFrom0toN.ShowSequence(input)));
    }
}


