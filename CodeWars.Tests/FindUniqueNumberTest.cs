namespace CodeWars.Tests;

[TestFixture]
internal class FindUniqueNumberTest
{
    [TestCase(new[] { 1, 2, 2, 2 }, ExpectedResult = 1)]
    [TestCase(new[] { -2, 2, 2, 2 }, ExpectedResult = -2)]
    [TestCase(new[] { 11, 11, 14, 11, 11 }, ExpectedResult = 14)]
    public int BaseTest(IEnumerable<int> numbers) => FindUniqueNumber.GetUnique(numbers);
}
