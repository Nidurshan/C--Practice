namespace OOP.Classes
{
    public class HoursToSeconds
    {
        public HoursToSeconds()
        {
            // Console.WriteLine();
        }

        public void ConvertHoursToSeconds()
        {
            Console.Write("Enter hour/hours: ");
            var input = int.Parse(Console.ReadLine());

            var answer = input * 3600;
            Console.WriteLine(answer);
        }
    }
}
