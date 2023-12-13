namespace OOP.Classes
{
    public class InchesToFeet
    {
        public InchesToFeet()
        {
            // Console.WriteLine();
        }

        public void ConvertInchesToFeet()
        {
            Console.Write("Select one: Inch -> Feet (1), Feet -> Inch (2): ");
            var selection = int.Parse(Console.ReadLine());

            if (selection == 1)
            {
                Console.Write("Enter a inch value: ");
                var inch = int.Parse(Console.ReadLine());

                var inchesToFeet = inch / 12;
                Console.WriteLine("Feet: " + inchesToFeet);
            }
            else if (selection == 2)
            {
                Console.Write("Enter a feet value: ");
                var feet = int.Parse(Console.ReadLine());

                var feetToInches = feet * 12;
                Console.WriteLine("Inches: " + feetToInches);
            }
            else
            {
                Console.WriteLine("Invalid input!!!");
            }
        }
    }
}