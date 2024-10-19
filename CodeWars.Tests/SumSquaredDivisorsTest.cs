namespace CodeWars.Tests;

[TestFixture]
internal class SumSquaredDivisorsTest
{
	[TestCase(1, 250, "[[1, 1], [42, 2500], [246, 84100]]")]
	[TestCase(42, 250, "[[42, 2500], [246, 84100]]")]
	[TestCase(250, 500, "[[287, 84100]]")]
	[TestCase(1, 1, "[[1, 1]]")]
	public void Test(long start, long end, string expected)
	{
		Assert.That(SumSquaredDivisors.ListSquared(start, end), Is.EqualTo(expected));
		Assert.That(SumSquaredDivisors.listSquared(start, end), Is.EqualTo(expected));
	}
}
