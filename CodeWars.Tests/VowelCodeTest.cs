namespace CodeWars.Tests;

[TestFixture]
public class VowelCodeTest
{
    static IEnumerable<TestCaseData> DataForEncode
    {
        get
        {
            yield return new TestCaseData("hello").Returns("h2ll4");
            yield return new TestCaseData("How are you today?").Returns("H4w 1r2 y45 t4d1y?");
            yield return new TestCaseData("This is an encoding test.").Returns("Th3s 3s 1n 2nc4d3ng t2st.");
        }
    }

    [Test, TestCaseSource(nameof(DataForEncode))]
    public static string TestEncode(string msg) => VowelCode.Encode(msg);

    static IEnumerable<TestCaseData> DataForDecode
    {
        get
        {
            yield return new TestCaseData("h2ll4").Returns("hello");
            yield return new TestCaseData("H4w 1r2 y45 t4d1y?").Returns("How are you today?");
            yield return new TestCaseData("Th3s 3s 1n 2nc4d3ng t2st.").Returns("This is an encoding test.");
        }
    }

    [Test, TestCaseSource(nameof(DataForDecode))]
    public static string TestDecode(string msg) => VowelCode.Decode(msg);
}
