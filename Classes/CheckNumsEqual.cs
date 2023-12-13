namespace OOP.Classes
{
    public class CheckNumsEqual
    {
        public CheckNumsEqual()
        {
            // Console.WriteLine();
        }

        public void CheckNumsAreEqual()
        {
            Console.Write("Enter first number: ");
            var input1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            var input2 = int.Parse(Console.ReadLine());

            if (input1 == input2)
            {
                Console.WriteLine("Numbers are equal.");
            }
            else
            {
                Console.WriteLine("Numbers are not equal.");
            }
        }
    }
}