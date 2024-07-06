namespace CodeWars.Tests;

internal class TestExamples
{
    // Example 1
    private static IEnumerable<TestCaseData> testCases
    {
        get
        {
            yield return new TestCaseData("Some", "parameters", "of", "the", "method").Returns("result of the method");
        }
    }

    [Test, TestCaseSource(nameof(testCases))]
    public static string Test_1(string[] array) => "Calling the method being checked";


    // Example 2
    [TestCase("Some parameters of the method", ExpectedResult = "result of the method")]
    public string Test_2(string str) => "Calling the method being checked";


    // Example 3
    [TestCase("Some parameters of the method", "result of the method")]
    public void Test_3(string parameters, string expected) => Assert.That($"Calling the method being checked with {parameters}", Is.EqualTo(expected));


    // Example 4 - Test Exception
    [TestCase("Some parameters of the method")]
    public void Test_4_Exceptions(string parameters)
    {
        Assert.That(() => "Calling the method being checked with an exception", Throws.Exception); // select the necessary exception, for example, Throws.ArgumentException
    }
}
