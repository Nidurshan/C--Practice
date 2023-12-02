namespace OOP.Classes
{
    public class XYZCalculation
    {
        public XYZCalculation()
        {
            // Console.WriteLine("");
        }

        public void Calculation()
        {
            Console.WriteLine("Welcome to XYZ Formulas :)");
            Console.Write("Select a method(1 or 2): 1. (x+y)z  2. (x.y) + (y.z): ");
            var selectedMethod = int.Parse(Console.ReadLine());

            Console.Write("Enter a value to X: ");
            var xValue = int.Parse(Console.ReadLine());

            Console.Write("Enter a value to Y: ");
            var yValue = int.Parse(Console.ReadLine());

            Console.Write("Enter a value to Z: ");
            var zValue = int.Parse(Console.ReadLine());

            if(selectedMethod == 1)
            {
                Console.WriteLine((xValue + yValue) * zValue);
            }
            else if(selectedMethod == 2)
            {
                Console.WriteLine((xValue * yValue) + (yValue * zValue));
            }
            else
            {
                Console.WriteLine("Undefined!");
            }
        }
    }
}