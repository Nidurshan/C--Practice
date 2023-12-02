namespace OOP.Classes
{
    public class PrintSomethingForAge
    {
        public PrintSomethingForAge()
        {
            // Console.WriteLine();
        }

        public void Container()
        {
            Console.Write("Enter your age: ");
            int getAge = int.Parse(Console.ReadLine());

            Console.WriteLine("You look older than " + getAge);
        }
    }
}