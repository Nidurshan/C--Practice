namespace OOP.Classes
{
    public class NameGreeting
    {
        public NameGreeting()
        {
            // Console.WriteLine();
        }

        public void GetNameGreeting()
        {
            Console.Write("Enter a name: ");
            var name = Console.ReadLine();

            Console.WriteLine($"Hello {name}!");
        }
    }
}