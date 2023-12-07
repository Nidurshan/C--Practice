namespace OOP.Classes
{
    public class FindNthOddNum
    {
        public FindNthOddNum()
        {
            // Console.WriteLine();
        }

        public void GetNthOddNumber()
        {
            Console.WriteLine("Formula to find Nth odd number: Tn = a + (n - 1) d");
            Console.WriteLine("a = first odd number");
            Console.WriteLine("n = orgam");
            Console.WriteLine("d = common difference");
            
            Console.Write("Enter a value to a: ");
            var aValue = int.Parse(Console.ReadLine());

            Console.Write("Enter a value to n: ");
            var nValue = int.Parse(Console.ReadLine());

            Console.Write("Enter a value to d: ");
            var dValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Tn = " + (aValue + (nValue - 1) * dValue));
        }
    }
}