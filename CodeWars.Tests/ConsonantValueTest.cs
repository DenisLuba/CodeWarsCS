namespace CodeWars.Tests;

[TestFixture]
public class ConsonantValueTest
{
    static IEnumerable<TestCaseData> caseDatas
    {
        get
        {
            yield return new TestCaseData("zodiac").Returns(26);
            yield return new TestCaseData("chruschtschov").Returns(80);
            yield return new TestCaseData("khrushchev").Returns(38);
            yield return new TestCaseData("strength").Returns(57);
            yield return new TestCaseData("catchphrase").Returns(73);
            yield return new TestCaseData("twelfthstreet").Returns(103);
            yield return new TestCaseData("mischtschenkoana").Returns(80);
        }
    }

    [Test, TestCaseSource(nameof(caseDatas))]
    public int Test(string s) => ConsonantValue.Solve(s);
}
