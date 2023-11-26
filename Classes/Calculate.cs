namespace OOP.Classes
{
    public class Calculator
    {
        public int FirstNum { get; set; } = 0;
        public int SecondNum { get; set; } = 0;

        public Calculator()
        {
            // Console.WriteLine($"");
        }

        public Calculator(int firstNum, int secondNum)
        {
            FirstNum = firstNum;
            SecondNum = secondNum;
        }


        public void Add()
        {
            Console.WriteLine(FirstNum + SecondNum);
        }
        public int Add(int a, int b)
        {
            return a + b;
        }

        public void Substract()
        {
            Console.WriteLine(FirstNum - SecondNum);
        }

        public void Substract(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        public void Multiply()
        {
            Console.WriteLine(FirstNum * SecondNum);
        }

        public void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        public void Divide()
        {
            Console.WriteLine(FirstNum / SecondNum);
        }

        public void Divide(int a, int b)
        {
            Console.WriteLine(a / b);
        }

    }
}