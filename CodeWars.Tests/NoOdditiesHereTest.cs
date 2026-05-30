namespace CodeWars.Tests;

[TestFixture]
internal class NoOdditiesHereTest
{
    [Test]
    public void OneThroughFive()
    {
        Assert.That(NoOdditiesHere.NoOdds([1, 2, 3, 4, 5]), Is.EqualTo(new int[] { 2, 4 }));
    }
}
