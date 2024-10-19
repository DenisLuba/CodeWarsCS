using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace CodeWars;

public class SumSquaredDivisors
{
	public static string ListSquared(long start, long end)
		=> "[" 
		+ string.Join(", ", Range(start, end)
			.Select(x => ( x, Range(1L, x).Where(i => x % i == 0).Sum(i => i * i)))
			.Where(tuple => Math.Sqrt(tuple.Item2) % 1 == 0)
			.Select(tuple => $"[{tuple.Item1}, {tuple.Item2}]")) 
		+ "]";

	static IEnumerable<long> Range(long start, long end)
	{
		for (var i = start; i <= end; i++)
			yield return i;
	}

	// a faster solution
	public static string listSquared(long start, long end)
	{
		var line = new StringBuilder("[");

		for (long number = start; number <= end; number++)
		{
			var sumDivisorsSquares = 0L;

			for (long divisor = 1; divisor <= number; divisor++)
				if (number % divisor == 0) sumDivisorsSquares += divisor * divisor;

			if (Math.Sqrt(sumDivisorsSquares) % 1 == 0) line.Append($"[{number}, {sumDivisorsSquares}], ");
		}
		var lineLength = line.Length;
		return ( lineLength >= 2 ? line.Remove(line.Length - 2, 2) : line).Append("]").ToString();
	}
}
