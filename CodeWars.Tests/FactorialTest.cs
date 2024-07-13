using NuGet.Frameworks;

namespace CodeWars.Tests
{
    [TestFixture]
    internal class FactorialTest
    {
        [TestCase(0, 1)]
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 6)]
        public void Test(int input, int expected) 
            => Assert.That(Factorial.GetFactorial(input), Is.EqualTo(expected));

        [TestCase(-5)]
        [TestCase(13)]
        public void Test(int input)
            => Assert.That(() => Factorial.GetFactorial(input), Throws.ArgumentException);
    }
}
