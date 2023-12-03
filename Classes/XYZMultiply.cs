namespace OOP.Classes
{
    public class XYZMultiply
    {
        public XYZMultiply()
        {
            // Console.WriteLine();
        }

        public void XYZMultiplication()
        {
            Console.Write("Enter a value to X: ");
            int inputX = int.Parse(Console.ReadLine());

            Console.Write("Enter a value to Y: ");
            int inputY = int.Parse(Console.ReadLine());

            Console.Write("Enter a value to Z: ");
            int inputZ = int.Parse(Console.ReadLine());

            Console.WriteLine(inputX * inputY * inputZ);
        }
    }
}