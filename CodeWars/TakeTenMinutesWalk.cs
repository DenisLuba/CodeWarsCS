namespace CodeWars;

public class TakeTenMinutesWalk
{
    public static bool IsValidWalk(string[] walk)
        => walk.Length == 10
        && walk.Count(w => w == "w") == walk.Count(w => w == "e")
        && walk.Count(w => w == "n") == walk.Count(w => w == "s");
}
