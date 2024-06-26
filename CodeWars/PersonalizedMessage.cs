namespace CodeWars;

public class PersonalizedMessage
{
    public static string Greet(string name, string owner) 
        => name == owner ? "Hello boss" : "Hello guest";
}
