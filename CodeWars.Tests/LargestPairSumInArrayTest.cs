namespace CodeWars.Tests;

[TestFixture]
public class LargestPairSumInArrayTest
{
    [Test]
    public void SampleTest()
    {
        Assert.Multiple(() =>
        {
            Assert.That(LargestPairSumInArray.LargestPairSum(new int[] { -8, -8, -16, -18, -19 }), Is.EqualTo(-16));
            Assert.That(LargestPairSumInArray.LargestPairSum(new int[] { -100, -29, -24, -19, 19 }), Is.EqualTo(0));
            Assert.That(LargestPairSumInArray.LargestPairSum(new int[] { 1, 2, 3, 4, 6, -1, 2 }), Is.EqualTo(10));
            Assert.That(LargestPairSumInArray.LargestPairSum(new int[] { 10, 14, 2, 23, 19 }), Is.EqualTo(42));
        });
    }

    public void TestFastestMethod()
    {
        Assert.Multiple(() =>
        {
            Assert.That(LargestPairSumInArray.FastestLargestPairSum(new int[] { -8, -8, -16, -18, -19 }), Is.EqualTo(-16));
            Assert.That(LargestPairSumInArray.FastestLargestPairSum(new int[] { -100, -29, -24, -19, 19 }), Is.EqualTo(0));
            Assert.That(LargestPairSumInArray.FastestLargestPairSum(new int[] { 1, 2, 3, 4, 6, -1, 2 }), Is.EqualTo(10));
            Assert.That(LargestPairSumInArray.FastestLargestPairSum(new int[] { 10, 14, 2, 23, 19 }), Is.EqualTo(42));
        });
    }
}
