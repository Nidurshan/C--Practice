namespace OOP.Classes
{
    public class ReversedString
    {
        public ReversedString()
        {
            // Console.WriteLine();
        }

        public void Reversed()
        {
            string movie = "Avengers";
            string reversedString = new string(movie.ToCharArray().Reverse().ToArray());

            Console.WriteLine("Original String: " + movie);
            Console.WriteLine("Reversed String: " + reversedString);
        }
    }
}