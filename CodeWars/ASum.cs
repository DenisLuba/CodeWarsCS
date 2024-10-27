namespace CodeWars;

public class ASum
{
	public static long FindNb(long m)
	{
		var s = 0l;
		var i = 0l;

		while (s < m)
		{
			s += (i * i * i);
			i++;
		}
		return s == m ? --i : -1;
	}
}
