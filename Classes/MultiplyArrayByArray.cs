namespace OOP.Classes
{
    public class MultiplicationTable
    {
        public MultiplicationTable()
        {
            // Console.WriteLine();
        }

        public void MultiplyFunc()
        {
            Console.WriteLine("Welcome to C# multiplycation table :)");
            int[] numArray = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15};

            Console.Write("Enter a number: ");
            var inputNum = int.Parse(Console.ReadLine());

            for(int i = 0; i < numArray.Length; i++)
            {
                Console.WriteLine(numArray[i] * inputNum);
            }
        }
    }
}