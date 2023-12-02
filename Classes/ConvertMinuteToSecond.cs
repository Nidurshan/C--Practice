namespace OOP.Classes
{
    public class MinuteToSecond
    {
        public MinuteToSecond()
        {
            // Console.WriteLine();
        }

        public void ConvertMinuteToSecond()
        {
            Console.Write("Enter a value: ");
            int minute = int.Parse(Console.ReadLine());

            Console.WriteLine(minute * 60 + " Seconds");
        }
    }
}