namespace OOP.Classes
{
    public class Converter
    {

        public Converter()
        {

        }

        public void KM2M(int km)
        {
            Console.WriteLine(km * 1000);
        }

        public void M2KM(int m)
        {
            Console.WriteLine(m / 1000);
        }
    }
}