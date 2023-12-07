namespace OOP.Classes
{
    public class CheckArrayContainOddNum
    {
        public CheckArrayContainOddNum()
        {
            // Console.WriteLine();
        }

        public void CheckArrayContainOddNumber()
        {
            int[] intNums = {2,16,7,32,4,9,120};

            for(int i = 0; i < intNums.Length; i++)
            {
                if(intNums[i] % 2 != 0)

                {
                    Console.WriteLine("Odd number found!");
                }
                else
                {
                    Console.WriteLine("There are no odd numbers.");
                }
            }
        }
    }
}