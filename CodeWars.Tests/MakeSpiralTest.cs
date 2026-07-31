namespace CodeWars.Tests;

public class MakeSpiralTest
{
    static IEnumerable<TestCaseData> TestCases
    {
        get
        {
            yield return new TestCaseData(5).Returns(new int[,] {
                {1, 1, 1, 1, 1},
                {0, 0, 0, 0, 1},
                {1, 1, 1, 0, 1},
                {1, 0, 0, 0, 1},
                {1, 1, 1, 1, 1}
            });
            yield return new TestCaseData(6).Returns(new int[,]
            {
                {1, 1, 1, 1, 1, 1},
                {0, 0, 0, 0, 0, 1},
                {1, 1, 1, 1, 0, 1},
                {1, 0, 0, 1, 0, 1},
                {1, 0, 0, 0, 0, 1},
                {1, 1, 1, 1, 1, 1}
            });
            yield return new TestCaseData(8).Returns(new int[,] {
                {1, 1, 1, 1, 1, 1, 1, 1},
                {0, 0, 0, 0, 0, 0, 0, 1},
                {1, 1, 1, 1, 1, 1, 0, 1},
                {1, 0, 0, 0, 0, 1, 0, 1},
                {1, 0, 1, 0, 0, 1, 0, 1},
                {1, 0, 1, 1, 1, 1, 0, 1},
                {1, 0, 0, 0, 0, 0, 0, 1},
                {1, 1, 1, 1, 1, 1, 1, 1},
            });
            yield return new TestCaseData(1).Returns(new int[,] {
                { 1 }
            });
        }
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public int[,] SpiralizeTest(int size)
    {
        return MakeSpiral.Spiralize(size);
    }
}
