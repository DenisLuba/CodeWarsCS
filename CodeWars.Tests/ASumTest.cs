namespace CodeWars.Tests;

[TestFixture]
internal class ASumTest
{
	[TestCase(2022, 4183059834009)]
	[TestCase(-1, 24723578342962)]
	[TestCase(3568, 40539911473216)]
	[TestCase(4824, 135440716410000)]
	public static void Test(long expected, long m)
		=> Assert.That(expected, Is.EqualTo(ASum.FindNb(m)));
}
