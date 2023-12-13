namespace OOP.Classes
{
    public class FindLargestNum
    {
        public FindLargestNum()
        {
            // Console.WriteLine();
        }

        public void GetLargestNum()
        {
            Console.Write("Enter first num: ");
            var inputA = int.Parse(Console.ReadLine());

            Console.Write("Enter second num: ");
            var inputB = int.Parse(Console.ReadLine());

            if (inputA < inputB)
            {
                Console.WriteLine($"{inputA} less than {inputB}");
            }
            else if (inputA > inputB)
            {
                Console.WriteLine($"{inputA} greater than {inputB}");
            }
            else
            {
                Console.WriteLine($"{inputA} and {inputB} are equal numbers");
            }
        }
    }
}