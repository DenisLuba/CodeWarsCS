namespace CodeWars.Tests;

[TestFixture]
internal class SumOfMultiplesTest
{
    [Test, Description("Should produce ecpected results for valid inputs")]
    [Order(1)]
    public void SampleTest()
    {
        Assert.Multiple(() =>
        {
            Assert.That(SumOfMultiples.SumMul(2, 9), Is.EqualTo(20), "n = 2, m = 9");
            Assert.That(SumOfMultiples.SumMul(5, 20), Is.EqualTo(30), "n = 5, m = 20");
            Assert.That(SumOfMultiples.SumMul(4, 123), Is.EqualTo(1860), "n = 4, m = 123");
            Assert.That(SumOfMultiples.SumMul(123, 4567), Is.EqualTo(86469), "n = 123, m = 4567");
        });
    }

    [Test, Description("Should throw for invalid inputs")]
    [Order(2)]
    public void ErrorTest()
    {
        Assert.Multiple(() =>
        {
            Assert.That(() => SumOfMultiples.SumMul(4, 1), Throws.TypeOf<ArgumentException>(), "n = 4, m = 1");
            Assert.That(() => SumOfMultiples.SumMul(0, 20), Throws.TypeOf<ArgumentException>(), "n = 0, m = 20");
        });
    }
}
