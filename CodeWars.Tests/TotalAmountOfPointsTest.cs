namespace CodeWars.Tests
{
    public class TotalAmountOfPointsTest
    {
        [TestCase(new[] { "1:0", "2:0", "3:0", "4:0", "2:1", "3:1", "4:1", "3:2", "4:2", "4:3" }, 30)]
        [TestCase(new[] { "1:1", "2:2", "3:3", "4:4", "2:2", "3:3", "4:4", "3:3", "4:4", "4:4" }, 10)]
        [TestCase(new[] { "0:1", "0:2", "0:3", "0:4", "1:2", "1:3", "1:4", "2:3", "2:4", "3:4" }, 0)]
        [TestCase(new[] { "1:0", "2:0", "3:0", "4:0", "2:1", "1:3", "1:4", "2:3", "2:4", "3:4" }, 15)]
        [TestCase(new[] { "1:0", "2:0", "3:0", "4:4", "2:2", "3:3", "1:4", "2:3", "2:4", "3:4" }, 12)]
        public void Test(string[] scores, int points)
        {
            Assert.That(TotalAmountOfPoints.TotalPoints(scores), Is.EqualTo(points));
        }
    }
}
