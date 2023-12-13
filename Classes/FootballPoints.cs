namespace OOP.Classes
{
    public class FootballPoints
    {
        public int Wins { get; set; } = 3;
        public int Draws { get; set; } = 1;
        public int Losses { get; set; } = 0;
        public FootballPoints()
        {
            // Console.WriteLine();
        }

        public FootballPoints(int wins, int draws, int losses)
        {
            Wins = wins;
            Draws = draws;
            Losses = losses;
        }

        public void GetFootballPoints()
        {
            Console.Write("Enter wins game value: ");
            var gameWins = int.Parse(Console.ReadLine());

            Console.Write("Enter draws game value: ");
            var gameDraws = int.Parse(Console.ReadLine());

            Console.Write("Enter losses game value: ");
            var gameLosses = int.Parse(Console.ReadLine());

            var gameWinScore = Wins * gameWins;
            var gameDrawsScore = Draws * gameDraws;
            var gameLossesScore = Losses * gameLosses;

            
        }
    }
}