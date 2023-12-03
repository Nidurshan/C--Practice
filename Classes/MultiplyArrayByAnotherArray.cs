namespace OOP.Classes
{
    public class MultiplyArrayByArray
    {
        public MultiplyArrayByArray()
        {
            // Console.WriteLine();
        }

        public void ArrayMultiply()
        {
            int[] array1 = {1,9,4,5,-3,8,2,7};
            int[] array2 = {9,-5,7,3,6,4,2,8};

            for(int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array1[i] * array2[i]);
            }
        }
    }
}
