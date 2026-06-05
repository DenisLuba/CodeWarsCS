namespace CodeWars.Tests;

[TestFixture]
internal class LikesAnswerTest
{
    static readonly string[] test_1 = [];
	static readonly string[] test_2 = [ "Peter" ];
	static readonly string[] test_3 = [ "Jacob", "Alex" ];
	static readonly string[] test_4 = [ "Max", "John", "Mark" ];
	static readonly string[] test_5 = [ "Alex", "Jacob", "Mark", "Max" ];

	static IEnumerable<TestCaseData> TestCases
	{
		get
		{
			yield return new TestCaseData([test_1]).Returns("no one likes this");
			yield return new TestCaseData([test_2]).Returns("Peter likes this");
			yield return new TestCaseData([test_3]).Returns("Jacob and Alex like this");
			yield return new TestCaseData([test_4]).Returns("Max, John and Mark like this");
			yield return new TestCaseData([test_5]).Returns("Alex, Jacob and 2 others like this");
		}
	}

	[Test, TestCaseSource(nameof(TestCases))]
	public string Test(string[] names) => LikesAnswer.Likes(names);
}
