namespace CodeWars.Tests;

[TestFixture]
public class HexToDecimalTest
{
    [Test]
    public void BasicTests()
    {
        Assert.Multiple(() =>
        {
            Assert.That(HexToDecimal.HexToDec("1"), Is.EqualTo(1));
            Assert.That(HexToDecimal.HexToDec("a"), Is.EqualTo(10));
            Assert.That(HexToDecimal.HexToDec("10"), Is.EqualTo(16));
            Assert.That(HexToDecimal.HexToDec("FF"), Is.EqualTo(255));
            Assert.That(HexToDecimal.HexToDec("-C"), Is.EqualTo(-12));
        });        
    }
}
