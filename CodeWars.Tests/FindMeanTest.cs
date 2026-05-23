namespace CodeWars.Tests;

[TestFixture]
internal class FindMeanTest
{
    [Test, Order(1)]
    public void FirstTest()
    {
        Assert.That(FindMean.FindAverage([1]), Is.EqualTo(1));
    }

    [Test, Order(2)]
    public void SecondTest()
    {
        Assert.That(FindMean.FindAverage([-10, -5, -5, 0]), Is.EqualTo(-5));
    }

    [Test, Order(3)]
    public void ThirdTest()
    {
        Assert.That(FindMean.FindAverage([1, 3, 5, 7]), Is.EqualTo(4));
    }

    [Test, Order(4)]
    public void FourthTest()
    {
        Assert.That(FindMean.FindAverage([0]), Is.EqualTo(0));
    }
}
