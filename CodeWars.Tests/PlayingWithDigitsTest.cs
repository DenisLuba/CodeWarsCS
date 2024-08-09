namespace CodeWars.Tests
{
    [TestFixture]
    internal class PlayingWithDigitsTest
    {
        [TestCase(89, 1, 1)]
        [TestCase(92, 1, -1)]
        [TestCase(695, 2, 2)]
        [TestCase(46288, 3, 51)]
        public void Test(int n, int p, int expected)
            => Assert.That(PlayingWithDigits.DigPow(n, p), Is.EqualTo(expected));
    }
}
