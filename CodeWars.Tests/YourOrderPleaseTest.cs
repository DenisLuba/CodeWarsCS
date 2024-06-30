namespace CodeWars.Tests
{
    [TestFixture]
    internal class YourOrderPleaseTest
    {
        [TestCase("is2 Thi1s T4est 3a", ExpectedResult = "Thi1s is2 3a T4est")]
        [TestCase("4of Fo1r pe6ople g3ood th5e the2", ExpectedResult = "Fo1r the2 g3ood 4of th5e pe6ople")]
        [TestCase("", ExpectedResult = "")]
        public string Test(string words) => YourOrderPlease.Order(words);
    }
}
