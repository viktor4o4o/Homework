namespace _15.Calculator
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {

            int firstNum = int.Parse(Console.ReadLine());
            var operator1 = Console.ReadLine();
            int secondNum = int.Parse(Console.ReadLine());

            if (operator1 == "+" )
            {
                int result = firstNum + secondNum;
                Console.WriteLine($"{firstNum} + {secondNum} = {result}");
            }
            else if (operator1 == "-")
            {
                int result = firstNum - secondNum;
                Console.WriteLine($"{firstNum} - {secondNum} = {result}");
            }
            else if (operator1 == "*")
            {
                int result = firstNum * secondNum;
                Console.WriteLine($"{firstNum} * {secondNum} = {result}");
            }
            else if (operator1 == "/")
            {
                int result = firstNum / secondNum;
                Console.WriteLine($"{firstNum} / {secondNum} = {result}");
            }
        }
    }
}
