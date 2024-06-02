namespace CodeWars.Tests
{
    [TestFixture]
    internal class SortNumbersTest
    {
        [Test]
        public void BasicTest()
        {
            checkSortNumbers(new int[] { 1, 2, 3, 10, 5 }, new int[] { 1, 2, 3, 5, 10 });
            checkSortNumbers(null, new int[] { });
            checkSortNumbers(new int[] { }, new int[] { });
            checkSortNumbers(new int[] { 20, 2, 10 }, new int[] { 2, 10, 20 });
            checkSortNumbers(new int[] { 2, 20, 10 }, new int[] { 2, 10, 20 });
            checkSortNumbers(new int[] { 2, 10, 20 }, new int[] { 2, 10, 20 });
        }

        private void checkSortNumbers(int[]? numbers, int[] expected)
        {
            var actual = SortNumbers.SortNums(numbers);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
