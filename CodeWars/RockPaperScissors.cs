namespace CodeWars
{
    public class RockPaperScissors
    {
        private const string p1Won = "Player 1 won!";
        const string p2Won = "Player 2 won!";
        const string draw = "Draw!";

        const string rock = "rock";
        const string scissors = "scissors";
        const string paper = "paper";

        public static string Rps(string p1, string p2) => p1 switch
        {
            rock => p2 == rock ? draw : p2 == scissors ? p1Won : p2Won,
            scissors => p2 == scissors ? draw : p2 == rock ? p2Won : p1Won,
            _ => p2 == paper ? draw : p2 == rock ? p1Won : p2Won
        };
    }
}
