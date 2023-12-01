namespace OOP.Classes
{
    public class FindLargestNum
    {
        public FindLargestNum()
        {
            // Console.WriteLine();
        }

        public void FindLargestElement()
        {
            int[] nums = {5, 8, 12, 21, 3, 25, 9, 16, 100, 4};
            int largestElement = nums.Max();

            Console.WriteLine("The The maximum element in the array is: " + largestElement);
        }
    }
}