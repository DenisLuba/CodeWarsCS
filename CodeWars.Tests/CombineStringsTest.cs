namespace CodeWars.Tests;

[TestFixture]
public class CombineStringsTest
{

    [TestCase("James", "Stevenson", ExpectedResult = "James Stevenson")]
    public static string FixedTest(string a, string b)
        => CombineStrings.CombineNames(a, b);
}
