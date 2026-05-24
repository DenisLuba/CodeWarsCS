namespace CodeWars.Tests;

[TestFixture]
internal class FlowerDivinationTest
{
    [Test]
    public void SampleTests()
    {
        Assert.Multiple(() =>
        {
            Assert.That(FlowerDivination.HowMuchILoveYou(7), Is.EqualTo("I love you"));
            Assert.That(FlowerDivination.HowMuchILoveYou(3), Is.EqualTo("a lot"));
            Assert.That(FlowerDivination.HowMuchILoveYou(6), Is.EqualTo("not at all"));
        });
    }
}
