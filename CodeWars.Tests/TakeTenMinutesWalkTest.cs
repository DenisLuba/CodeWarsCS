namespace CodeWars.Tests;

[TestFixture]
internal class TakeTenMinutesWalkTest
{
    [Test]
    [Order(1)]
    public void SampleTests()
    {
        Assert.Multiple(() =>
        {
            Assert.That(TakeTenMinutesWalk.IsValidWalk(["n", "s", "n", "s", "n", "s", "n", "s", "n", "s"]), Is.True, "should return true");
            Assert.That(TakeTenMinutesWalk.IsValidWalk(["w", "e", "w", "e", "w", "e", "w", "e", "w", "e", "w", "e"]), Is.False, "should return false");
            Assert.That(TakeTenMinutesWalk.IsValidWalk(["w"]), Is.False, "should return false");
            Assert.That(TakeTenMinutesWalk.IsValidWalk(["n", "n", "n", "s", "n", "s", "n", "s", "n", "s"]), Is.False, "shuld return false");
        });

    }
}
