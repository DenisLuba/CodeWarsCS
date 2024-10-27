using System.Numerics;

namespace CodeWars;

public class PascalDiagonal
{
	public static BigInteger Diagonal(int n, int k) => Binominal(n + 1, k + 1);
	// public static BigInteger Diagonal(int n, int k) => Factorial(n + 1) / (Factorial(k + 1) * Factorial(n - k));

	static BigInteger Factorial(int n) 
		=> Enumerable
		.Range(1, n)
		.Aggregate(new BigInteger(1), (f, i) => f * i);

	static BigInteger Binominal (int row, int pos)
	{
		BigInteger koef = 1;
		int i;
		if (row - pos > pos)
			pos = row - pos;
		for (i = pos + 1; i <= row; i++)
			koef = koef * i;
		for (i = 1; i <= (row - pos); i++)
			koef = koef / i;
		return koef;
	}
}
