namespace CodeWars.Tests;

[TestFixture]
internal class SortedYesNoHowTest
{
    [Test]
    public void BasicTest()
    {
        Assert.Multiple(() =>
        {
            Assert.That(SortedYesNoHow.IsSortedAndHow([1, 2]), Is.EqualTo("yes, ascending"));
            Assert.That(SortedYesNoHow.IsSortedAndHow([15, 7, 3, -8]), Is.EqualTo("yes, descending"));
            Assert.That(SortedYesNoHow.IsSortedAndHow([4, 2, 30]), Is.EqualTo("no"));
        });
    }
}
