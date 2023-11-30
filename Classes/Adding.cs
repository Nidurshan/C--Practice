namespace OOP.Classes
{
    public class Add
    {
        public Add()
        {
            // Console.WriteLine();
        }

        public void AddInputs()
        {
            Console.WriteLine("Welcome to the Adding program");

            Console.Write("Enter Num1: ");
            int inputA = int.Parse(Console.ReadLine());

            Console.Write("Enter Num2: ");
            int inputB = int.Parse(Console.ReadLine());

            int answer = inputA + inputB;
            Console.WriteLine("Answer: " + answer);
        }
    }
}