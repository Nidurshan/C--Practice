namespace OOP.Classes
{
    public class PrintOddNumbers
    {
        public PrintOddNumbers()
        {
            // Console.WriteLine();
        }

        public void PrintOddNums()
        {
            for(int i = 1; i <= 99; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}