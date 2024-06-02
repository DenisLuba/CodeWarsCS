namespace CodeWars.Tests
{
    [TestFixture]
    internal class CalculateBMITest
    {
        [TestCase(100, 1.5, "Obese")]
        [TestCase(100, 1.9, "Overweight")]
        [TestCase(100, 2, "Normal")]
        [TestCase(100, 2.5, "Underweight")]
        public static void Test(double weight, double height, string expected)
            => Assert.That(CalculateBMI.Bmi(weight, height), Is.EqualTo(expected));    
    }
}
