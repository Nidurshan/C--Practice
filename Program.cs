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

            //============= Multiplication Table ==============

            var multiplicationTable = new MultiplicationTable();

            Console.WriteLine("Welcome to C# Multiplier :)");
            Console.WriteLine("");
            Console.Write("Num1: ");
            var input1 = int.Parse(Console.ReadLine());

            Console.Write("Num2: ");
            var input2 = int.Parse(Console.ReadLine());

            multiplicationTable.multiply(input1, input2);

            //============= Reversed String ================

            var reversed = new ReversedString();
            reversed.Reversed();
        }
    }
}