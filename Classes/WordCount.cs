namespace OOP.Classes
{
    public class WordCount
    {
        public WordCount()
        {
            // Console.WriteLine("");
        }


        public void CountWords()
        {
            var sentence = "In the heart of a bustling city, skyscrapers pierce the sky, casting long shadows over crowded streets. People hurriedly move, each with a purpose known only to them. Street vendors create a symphony of scents, enticing passersby. Amidst the chaos, a sense of unity emerges—a shared journey in the urban tapestry.";

            string[] words = sentence.Split(new[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            int count = words.Length;
            Console.WriteLine($"There are {count} words.");
        }
    }
}