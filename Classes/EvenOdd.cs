namespace OOP.Classes
{
    public class EvenOrOdd
    {
        public EvenOrOdd()
        {
            // Console.WriteLine();
        }

        public void CheckEvenOrOdd()
        {
            Console.Write("Enter a number: ");
            int inputNum = int.Parse(Console.ReadLine());

            if (inputNum % 2 == 0)
            {
                Console.WriteLine("This is a even number");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("This is a odd number");
                Console.WriteLine("");
            }
        }

        public void Thank()
        {
            Console.Write("Is this useful? Enter your answer: ");
            Console.ReadLine();
            Console.WriteLine("Thanks for your feedback :)");
        }
    }
}