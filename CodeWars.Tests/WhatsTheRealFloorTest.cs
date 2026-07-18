namespace CodeWars.Tests;

[TestFixture]
public class WhatsTheRealFloorTest
{
    [TestCase(1, 0)]
    [TestCase(5, 4)]
    [TestCase(15, 13)]
    public void SampleTest(int input, int expected)
        => Assert.That(WhatsTheRealFloor.GetRealFloor(input), Is.EqualTo(expected));
}
