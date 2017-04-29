namespace _04.Nth_Digit
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());
            var result = FindNthDigit(number, index);
            Console.WriteLine(result);


        }
        static int FindNthDigit(long number, int index)
        {
            var digit = 0;
            for (int i = 0; i < index; i++)
            {
               digit= (int)number % 10;
               number = number / 10;
            }
            return digit;
        }
    }
}
