namespace OOP.Classes
{
    public class MonthFinder
    {
        public MonthFinder()
        {
            // Console.WriteLine();
        }

        public void GetMonthUsingNum()
        {
            Console.WriteLine("WELCOME TO MONTH FINDER :)");
            Console.Write("Enter a value between 1 and 12: ");
            var input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                Console.WriteLine($"{input} = January");
            }
            else if (input == 2)
            {
                Console.WriteLine($"{input} = February");
            }
            else if (input == 3)
            {
                Console.WriteLine($"{input} = March");
            }
            else if (input == 4)
            {
                Console.WriteLine($"{input} = April");
            }
            else if (input == 5)
            {
                Console.WriteLine($"{input} = May");
            }
            else if (input == 6)
            {
                Console.WriteLine($"{input} = June");
            }
            else if (input == 7)
            {
                Console.WriteLine($"{input} = July");
            }
            else if (input == 8)
            {
                Console.WriteLine($"{input} = August");
            }
            else if (input == 9)
            {
                Console.WriteLine($"{input} = September");
            }
            else if (input == 10)
            {
                Console.WriteLine($"{input} = October");
            }
            else if (input == 11)
            {
                Console.WriteLine($"{input} = November");
            }
            else if (input == 12)
            {
                Console.WriteLine($"{input} = December");
            }
            else
            {
                Console.WriteLine("Invalid input!!");
            }
        }
    }
}