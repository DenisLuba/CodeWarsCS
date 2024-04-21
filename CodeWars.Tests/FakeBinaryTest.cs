namespace CodeWars.Test
{
    [TestFixture]
    internal class FakeBinaryTest
    {
        [TestCase("45385593107843568", "01011110001100111")]
        [TestCase("509321967506747", "101000111101101")]
        [TestCase("366058562030849490134388085", "011011110000101010000011011")]
        public void Test(string input, string output)
        {
            Assert.That(FakeBinary.FakeBin(input), Is.EqualTo(output));
        }
    }
}