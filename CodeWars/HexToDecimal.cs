namespace CodeWars;

public class HexToDecimal
{
    public static int HexToDec(string hexString)
        => hexString[0] == '-' 
        ? -Convert.ToInt32(hexString[1..], 16) 
        : Convert.ToInt32(hexString, 16);
}
