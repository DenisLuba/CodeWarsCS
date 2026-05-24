namespace CodeWars;

public class FlowerDivination
{
    readonly static string[] phrases = 
    [
        "I love you",
        "a little",
        "a lot",
        "passionately",
        "madly",
        "not at all"
    ];

    public static string HowMuchILoveYou(int petals) 
        => phrases[(petals - 1) % phrases.Length];
}
