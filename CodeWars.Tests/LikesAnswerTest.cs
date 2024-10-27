namespace CodeWars.Tests;

[TestFixture]
internal class LikesAnswerTest
{
	static IEnumerable<TestCaseData> TestCases
	{
		get
		{
			yield return new TestCaseData(Array.Empty<string>()).Returns("no one likes this");
			yield return new TestCaseData([ "Perer" ]).Returns("Peter likes this");
			yield return new TestCaseData([ "Jacob", "Alex" ]).Returns("Jacob and Alex like this");
			yield return new TestCaseData([ "Max", "John", "Mark" ]).Returns("Max, John and Mark like this");
			yield return new TestCaseData([ "Alex", "Jacob", "Mark", "Max" ]).Returns("Alex, Jacob and 2 others like this");
		}
	}

	[Test, TestCaseSource(nameof(TestCases))]
	public string Test(string[] names) => LikesAnswer.Likes(names);
}
