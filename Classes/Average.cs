namespace OOP.Classes 
{
    public class Average
    { 

        public Average()
        {
            
        }

        public double GetAverage(int[] nums)
        {
            var total = 0;
            foreach(int num in nums){
                total += num;
            }
            
            return (total / nums.Length);
        }
    }
}