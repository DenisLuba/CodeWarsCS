namespace CodeWars.Tests;

[TestFixture]
internal class FindRemainderTest
{
    [Test, Description("Your solution should handle arguments and math as defined in specifications")]
    public void FixedTest()
    {
        Assert.Multiple(() =>
        {
            Assert.That(FindRemainder.Remainder(17, 5), Is.EqualTo(2), "Returned value should be the value left over after dividing as much as possible.");
            Assert.That(FindRemainder.Remainder(72, 13), Is.EqualTo(FindRemainder.Remainder(13, 72)), "The order the arguments are passed should not matter.");
            Assert.Throws<DivideByZeroException>(() => FindRemainder.Remainder(0, 1));
            Assert.Throws<DivideByZeroException>(() => FindRemainder.Remainder(0, 0));
        });
    }
}
