using System.Collections.Generic;

namespace CodeWars.Tests;

[TestFixture]
internal class CountingSheepTest
{
    private static IEnumerable<TestCaseData> caseData
    {
        get
        {
            yield return new TestCaseData(new bool[] { true, false, true }).Returns(2);
            yield return new TestCaseData(new bool[] { false, false }).Returns(0);
            yield return new TestCaseData(new bool[] { true }).Returns(1);
            yield return new TestCaseData(new bool[] { }).Returns(0);
        }
    }

    [Test, TestCaseSource(nameof(caseData))]
    public static int Test(bool[] sheeps) => CountingSheep.CountSheeps(sheeps);
}
