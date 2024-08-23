namespace Method_Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentNumber num1 = new StudentNumber(15);
            StudentNumber num2 = new StudentNumber(20);
            StudentNumber resultSum = num1 + num2;
            Console.WriteLine(num1 + num2);

            StudentNumber num3 = new StudentNumber(9);
            StudentNumber num4 = new StudentNumber(16);
            num1 = num2;
            Console.WriteLine($"{num3} {num4}");    

            StudentNumber logicNum1 = new StudentNumber(5);
            StudentNumber logicNum2 = new StudentNumber(10);
            bool logicResult = logicNum1 & logicNum2;
            Console.WriteLine($"Logical AND result: {logicResult}");
        }
    }
}
