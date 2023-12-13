namespace OOP.Classes
{
    public class FindrectangleArea
    {
        public FindrectangleArea()
        {
            // Console.WriteLine();
        }

        public void GetAnswer()
        {
            Console.WriteLine("This formula is used for find rectangle's area: Area = Length x Width");

            Console.Write("Enter rectrangle's length: ");
            var length = int.Parse(Console.ReadLine());

            Console.Write("Enter rectrangle's width: ");
            var width = int.Parse(Console.ReadLine());

            string[] lengthValue = { "cm", "m" };
            Console.Write("Select cm (0) or m (1): ");
            var selectCmOrM = int.Parse(Console.ReadLine());


            Console.WriteLine("Selection: " + lengthValue[selectCmOrM]);

            var areaOfRectrangle = length * width;
            Console.WriteLine("Rectrangle's Area = " + areaOfRectrangle + lengthValue[selectCmOrM] + "^2");
        }
    }
}