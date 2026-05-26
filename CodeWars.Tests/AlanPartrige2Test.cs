namespace CodeWars.Tests;

[TestFixture]
internal class AlanPartrige2Test
{
    [Test]
    public void SampleTest()
    {
        Assert.Multiple(() =>
        {
            Assert.That(AlanPartrige2.Apple("50"), Is.EqualTo("It's hotter than the sun!!"));
            Assert.That(AlanPartrige2.Apple(4), Is.EqualTo("Help yourself to a honeycomb Yorkie for the glovebox."));
        });
    }
}
