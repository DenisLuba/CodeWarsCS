namespace CodeWars.Tests;

[TestFixture]
internal class AlternateCapitalizationTest
{
    [Test]
    public void MyTest()
    {
        Assert.Multiple(() =>
        {
            Assert.That(AlternateCapitalization.Capitalize("abcdef"), Is.EqualTo(new string[2] { "AbCdEf", "aBcDeF" }));
            Assert.That(AlternateCapitalization.Capitalize("codewars"), Is.EqualTo(new string[2] { "CoDeWaRs", "cOdEwArS" }));
            Assert.That(AlternateCapitalization.Capitalize("abracadabra"), Is.EqualTo(new string[2] { "AbRaCaDaBrA", "aBrAcAdAbRa" }));
            Assert.That(AlternateCapitalization.Capitalize("codewarriors"), Is.EqualTo(new string[2] { "CoDeWaRrIoRs", "cOdEwArRiOrS" }));

        });
    }
}
