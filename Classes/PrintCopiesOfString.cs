namespace OOP.Classes
{
    public class PrintStringCopies
    {
        public PrintStringCopies()
        {
            // Console.WriteLine();
        }

        public void CreateStringCopies()
        {
            var orgString = "The quick brown fox jumps over the lazy dog.";
            string[] splitArray = orgString.Split(" ");

            var getString = splitArray[8];
            var numberOfCopies = 5;
            var result = string.Concat(Enumerable.Repeat(getString, numberOfCopies));
            Console.WriteLine(result);
        }
    }
}