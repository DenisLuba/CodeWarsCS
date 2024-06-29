namespace CodeWars.Tests;

[TestFixture]
internal class GradeBookTest
{
    [TestCase(95, 90, 93, ExpectedResult = 'A')]
    [TestCase(70, 70, 100, ExpectedResult = 'B')]
    [TestCase(70, 71, 72, ExpectedResult = 'C')]
    [TestCase(65, 66, 60, ExpectedResult = 'D')]
    [TestCase(32, 15, 21, ExpectedResult = 'F')]
    public static char FixedTests(int n1, int n2, int n3) 
        => GradeBook.GetGrade(n1, n2, n3);
}
