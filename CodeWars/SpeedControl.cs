using System;
using System.Linq;
using System.Collections.Generic;

public class SpeedControl
{
	public static int Gps(int time, double[] array)
		=> (int)ZipWithNext(array, (x1, x2) => (3600 * (x2 - x1)) / time).Max();

	public static IEnumerable<R?> ZipWithNext<R, T>(T[] array, Func<T, T, R> func)
	{
		if (array.Length > 1)
		{
			for (int i = 1; i < array.Length; i++)
			{
				yield return func(array[i - 1], array[i]);
			}
		}
		else yield return default(R);
	}
}


