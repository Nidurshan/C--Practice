namespace OOP.Classes
{
    public class LessThan100
    {
        public LessThan100()
        {
            // Console.WriteLine();
        }

        public void CheckLessThan100()
        {
            Console.Write("Enter a value: ");
            var input = int.Parse(Console.ReadLine());

            if (input < 100)
            {
                Console.WriteLine($"{input} less than 100");
            }
            else
            {
                Console.WriteLine($"{input} greater than 100");
            }
        }
    }
}