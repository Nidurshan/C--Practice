namespace OOP.Classes
{
    public class AgeToDays
    {
        public AgeToDays()
        {
            // Console.WriteLine();
        }

        public void ConvertAgeToDays()
        {
            Console.Write("Enter your age: ");
            int inputAge = int.Parse(Console.ReadLine());

            Console.WriteLine(inputAge * 365);
            // var convertAgeToDays = inputAge * 365;
            // return convertAgeToDays;
        }
    }
}