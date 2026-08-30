namespace CodeWars.Tests;

[TestFixture]
public class LinearEquationsTest
{
    [TestCase("1 2 3 4\n6 6 7 8\n9 10 11 12", "(0; -1; 2)")]
    [TestCase("1 2 3 4", "(4; 0; 0) + q1 * (-2; 1; 0) + q2 * (-3; 0; 1)")]
    [TestCase("3/2 1/2 3", "(2; 0) + q1 * (-1/3; 1)")]
    [TestCase("1 2 2\n1 2 2\n2 4 4", "(2; 0) + q1 * (-2; 1)")]
    [TestCase("0 0 0\n0 0 0", "(0; 0) + q1 * (1; 0) + q2 * (0; 1)")]
    [TestCase("0 0 0 0\n0 0 0 0", "(0; 0; 0) + q1 * (1; 0; 0) + q2 * (0; 1; 0) + q3 * (0; 0; 1)")]
    [TestCase("1/20 -10/3 -10/9 -13\n-29 8 -27/4 0\n-26 -14 25 10/7", "(3343180/9270107; 4197595/1324301; 20461200/9270107)")]
    [TestCase("0 0 1 2 1\n1 2 1 3 1\n1 2 2 5 3", "NONE")]
    public void SimpleTest(string input, string output)
    {
        Assert.That(LinearEquations.Solve(input), Is.EqualTo(output));
        Console.WriteLine(LinearEquations.Solve(input));
    }

}
