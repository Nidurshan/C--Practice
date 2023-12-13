using System.Diagnostics;

namespace OOP.Classes
{
    public class FarmProblem
    {
        public FarmProblem()
        {
            // Console.WriteLine();
        }

        public void SolveFarmProblem()
        {
            Console.Write("Enter the number of chickens: ");
            var numOfChickens = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of cows: ");
            var numOfCows = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of pigs: ");
            var numOfPigs = int.Parse(Console.ReadLine());

            var chickenFeet = 2;
            var cowFeet = 4;
            var pigFeet = 4;

            var totalChickenLegs = numOfChickens * chickenFeet;
            var totalCowLegs = numOfCows * cowFeet;
            var totalPigLegs = numOfPigs * pigFeet;

            Console.WriteLine("Chicken legs: " + totalChickenLegs);
            Console.WriteLine("Cow Legs: " + totalCowLegs);
            Console.WriteLine("Pig legs: " + totalPigLegs);
            Console.WriteLine("Total legs: " + (totalChickenLegs + totalCowLegs + totalPigLegs));
        }
    }
}