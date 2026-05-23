namespace CodeWars.Tests;

[TestFixture]
internal class RemoveFirstAndLastCharacterPartTwoTest
{
    [Test]
    public void SampleTest()
    {
        Assert.Multiple(() =>
        {
            Assert.That(RemoveFirstAndLastCharacterPartTwo.Array(""), Is.Null);
            Assert.That(RemoveFirstAndLastCharacterPartTwo.Array("1"), Is.Null);
            Assert.That(RemoveFirstAndLastCharacterPartTwo.Array("1, 3"), Is.Null);
            Assert.That(RemoveFirstAndLastCharacterPartTwo.Array("1,2,3"), Is.EqualTo("2"));
            Assert.That(RemoveFirstAndLastCharacterPartTwo.Array("1,2,3,4"), Is.EqualTo("2 3"));
        });
    }
}
