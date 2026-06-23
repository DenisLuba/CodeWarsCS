namespace CodeWars.Tests;

[TestFixture]
internal class RemoveTheTimeTest
{
    [Test]
    public void SampleTest()
    {
        Assert.Multiple(() =>
        {
            Assert.That(RemoveTheTime.ShortenToDate("Friday May 2, 9am"), Is.EqualTo("Friday May 2"));
            Assert.That(RemoveTheTime.ShortenToDate("Tuesday January 29, 10pm"), Is.EqualTo("Tuesday January 29"));
            Assert.That(RemoveTheTime.ShortenToDate("Monday December 25, 10pm"), Is.EqualTo("Monday December 25"));
        });
    }
}
