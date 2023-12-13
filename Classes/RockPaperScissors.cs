namespace OOP.Classes
{
    public class RockPaperScissors
    {
        public RockPaperScissors()
        {
            // Console.WriteLine();
        }

        public void Game()
        {
            Console.WriteLine("WELCOME TO THE ROCK PAPER AND SCISSORS GAME :)");
            Console.WriteLine("");

            Console.Write("Choose Rock, Paper, or Scissors: ");
            var userChoice = Console.ReadLine();

            Random random = new Random();
            string[] options = { "Rock", "Paper", "Scissors" };
            var computerChoiceIndex = random.Next(options.Length);
            var computerChoice = options[computerChoiceIndex];

            Console.WriteLine($"You chose: {userChoice}");
            Console.WriteLine($"Computer chose: {computerChoice}");

            if (userChoice == computerChoice)
            {
                Console.WriteLine("Game draw!");
            }
            else if (userChoice == "Rock" && computerChoice == "Scissors" ||
                userChoice == "Paper" && computerChoice == "Rock" ||
                userChoice == "Scissors" && computerChoice == "Paper")
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("Computer wins!");
            }
        }
    }
}