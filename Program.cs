using OOP.Classes;
using System.Linq;

namespace OOP
{
    public class Program
    {
        public static void Main(string[] args)
        {

            string[] functions = { "Add", "Substract", "Multiply", "Divide" };

            Console.Write("Select -> Add(0), Substract(1), Multiply(2), Divide(3): ");
            var selection = int.Parse(Console.ReadLine());

            Console.WriteLine("Selection: " + functions[selection]);

            Console.Write("Num1: ");
            var num1 = int.Parse(Console.ReadLine());

            Console.Write("Num2: ");
            var num2 = int.Parse(Console.ReadLine());

            var calculator = new Calculator();

            if (selection == 0)
            {
                var result = calculator.Add(num1, num2);
                Console.WriteLine(result);
            }
            else if (selection == 1)
            {
                calculator.Substract(num1, num2);
            }
            else if (selection == 2)
            {
                calculator.Multiply(num1, num2);
            }
            else
            {
                calculator.Divide(num1, num2);
            }

            //======================= Weather Program ============================

            string[] weathers = { "Rain", "Wind", "Snow", "Cloud", "Winter" };

            Console.Write("Select Weather -> Rain(0), Wind(1), Snow(2), Cloud(3), Winter(4): ");
            var WeatherSelection = int.Parse(Console.ReadLine());

            Console.WriteLine("Selection: " + weathers[WeatherSelection]);

            var weather = new Weather();

            if (WeatherSelection == 0)
            {
                weather.Rain();
            }
            else if (WeatherSelection == 1)
            {
                weather.Wind();
            }
            else if (WeatherSelection == 2)
            {
                weather.Snow();
            }
            else if (WeatherSelection == 3)
            {
                weather.Cloud();
            }
            else if (WeatherSelection == 4)
            {
                weather.Winter();
            }
            else
            {
                Console.WriteLine("Undefined input!");
            }
            
            //================ Converter Program ===================

            var converter = new Converter();

            Console.Write("Km -> M (1), M -> Km (2): ");
            var select = int.Parse(Console.ReadLine());

            if (select == 1)
            {
                Console.WriteLine("Selected: Km -> M");
            }
            else if (select == 2)
            {
                Console.WriteLine("Selected: M -> Km");
            }
            else
            {
                Console.WriteLine("Undefinded");
            }

            Console.Write("Please enter a value: ");
            var input = int.Parse(Console.ReadLine());

            if (select == 1)
            {
                Console.WriteLine("Selected: Km -> M");
                converter.KM2M(input);
            }
            else if (select == 2)
            {
                Console.WriteLine("Selected: M -> Km");
                converter.M2KM(input);
            }
            else
            {
                Console.WriteLine("Undefinded");
            }

            //============= Reversed String ================

            var reversed = new ReversedString();
            reversed.Reversed();

            //============= Word Counter ================

            var wordCount = new WordCount();
            wordCount.CountWords();

            // ============= Even or Odd ==============

            var checkEvenOdd = new EvenOrOdd();
            checkEvenOdd.CheckEvenOrOdd();
            checkEvenOdd.Thank();

            //======== Rock Paper Scissors Game =========

            var rockPaperScissors = new RockPaperScissors();
            rockPaperScissors.Game();

            //========= Adding program =============

            var add = new Add();
            add.AddInputs();

            //========= Find largest element ==========

            var findLargestElement = new FindMaxAndMinNums();
            findLargestElement.FindLargestElement();

            //========= Average ===============
            
            var nums = new int[] {20,25,30,40,108};
            var average = new Average().GetAverage(nums);
            Console.WriteLine(average);

            //========= XYZCalculation ==========

            var xyzCalculation = new XYZCalculation();
            xyzCalculation.Calculation();

            //====== Multiplication Table =========

            var multiplicationTable = new MultiplicationTable();
            multiplicationTable.MultiplyFunc();

            //=========== Get Age ===============

            var printSomethingForAge = new PrintSomethingForAge();
            printSomethingForAge.Container();

            //========= Minute to Seconds ===========

            var minuteToSecond = new MinuteToSecond();
            minuteToSecond.ConvertMinuteToSecond();

            //========= Age to Days =========

            var ageToDays = new AgeToDays();
            ageToDays.ConvertAgeToDays();

            //======== Print Odd Numbers ==========

            var printOddNums = new PrintOddNumbers();
            printOddNums.PrintOddNums();

            //======== XYZ Multiply ===========

            var xyzMultiply = new XYZMultiply();
            xyzMultiply.XYZMultiplication();

            //========= Array Multiply =========

            var multiplyArrayByArray = new MultiplyArrayByArray();
            multiplyArrayByArray.ArrayMultiply();

            //======== Print String Copies ========

            var printStringCopies = new PrintStringCopies();
            printStringCopies.CreateStringCopies();

            //========= check Array Contain Odd Nums =========

            var checkArrayContainOdd = new CheckArrayContainOddNum();
            checkArrayContainOdd.CheckArrayContainOddNumber();

            //======== Find Nth Odd Num ===========

            var findNthOddNum = new FindNthOddNum();
            findNthOddNum.GetNthOddNumber();

            //========= Get rectrangle's area =========

            var getRectangleArea = new FindrectangleArea();
            getRectangleArea.GetAnswer();

            //======= Check Less Than 100 ========

            var lessThan100 = new LessThan100();
            lessThan100.CheckLessThan100();

            //======= Name Greeting =========

            var nameGreeting = new NameGreeting();
            nameGreeting.GetNameGreeting();
        }
    }
}