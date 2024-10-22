using System.Numerics;

namespace CodeWars.Tests;

[TestFixture]
internal class PascalDiagonalTest
{
	static IEnumerable<TestCaseData> cases
	{
		get
		{
			yield return new TestCaseData(20, 3).Returns(new BigInteger(5985));
			yield return new TestCaseData(20, 4).Returns(new BigInteger(20349));
			yield return new TestCaseData(20, 5).Returns(new BigInteger(54264));
		}
	}

	[Test, TestCaseSource(nameof(cases))]
	public BigInteger Test(int row, int pos) => PascalDiagonal.Diagonal(row, pos);
}
