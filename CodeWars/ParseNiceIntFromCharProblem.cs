namespace CodeWars;

public class ParseNiceIntFromCharProblem
{
    public static int GetAge(string input)
        //=> (int)char.GetNumericValue(input[0]);
        => input[0] - '0';
    //=> int.Parse(input[0].ToString());
}
