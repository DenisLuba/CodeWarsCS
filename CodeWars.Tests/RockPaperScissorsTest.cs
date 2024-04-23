namespace CodeWars.Test
{
    [TestFixture]
    internal class RockPaperScissorsTest
    {
        // Player 1 won!
        [TestCase("rock", "scissors", "Player 1 won!")]
        [TestCase("scissors", "paper", "Player 1 won!")]
        [TestCase("paper", "rock", "Player 1 won!")]

        // Player 2 won!
        [TestCase("scissors", "rock", "Player 2 won!")]
        [TestCase("paper", "scissors", "Player 2 won!")]
        [TestCase("rock", "paper", "Player 2 won!")]

        // Draw!
        [TestCase("rock", "rock", "Draw!")]
        [TestCase("scissors", "scissors", "Draw!")]
        [TestCase("paper", "paper", "Draw!")]

        public static void Test(string player1, string player2, string winner)
        {
            Assert.That(RockPaperScissors.Rps(player1, player2), Is.EqualTo(winner));
        }

        [Test]
        public static void Test2()
        {
            var arr = new[] { 1, 2, 5, 6 };
            Assert.That(arr.Average(), Is.EqualTo(3.5));
        }
    }
}
