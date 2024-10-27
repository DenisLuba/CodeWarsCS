namespace CodeWars;

public class LikesAnswer
{
	public static string Likes(string[] names)
		=> names.Length switch
		{
			0 => "no one likes this",
			1 => $"{names[0]} likes this",
			> 1 and < 4 => $"{string.Join(", ", names.SkipLast(1))} and {names.Last()} like this",
			_ => $"{string.Join(", ", names.Take(2))} and {names.Length - 2} others like this"
		};
}
