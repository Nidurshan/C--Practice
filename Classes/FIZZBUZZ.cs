namespace OOP.Classes
{
    public class FIZZBUZZChallenge
    {
        public FIZZBUZZChallenge()
        {
            // Console.WriteLine();
        }

        public void SolveFIZZBUZZChallenge()
        {
            Console.WriteLine("WELCOME TO FIZZBUZZ CHALLENGE :)");
            Console.WriteLine("If the number is divisible by three, it should be replaced by FIZZ");
            Console.WriteLine("If the number is divisible by five, it should be replaced by BUZZ");
            Console.WriteLine("If both conditions are met, the output should be FIZZBUZZ");

            for (int i = 1; i <= 1000; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FIZZBUZZ");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("FIZZ");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("BUZZ");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}