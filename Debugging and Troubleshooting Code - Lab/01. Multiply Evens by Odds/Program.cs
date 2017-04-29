namespace _01.Multiply_Evens_by_Odds
{
    using System;

    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            long result = GetOddEvenMultiplication(num);
            Console.WriteLine(result);
        }
        static long GetOddEvenMultiplication(int num)
        {
            long result = GetOddSum(num) * GetEvenSum(num);
            return result;
        }
        static long GetOddSum(int num)
        {
            num = Math.Abs(num);
            long sum = 0;
            while (num > 0)
            {
                var digit = num % 10;
                if (digit % 2 != 0)
                {
                    sum = sum + digit;
                }
                num /= 10;
            }
            return sum;
        }
        static long GetEvenSum(int num)
        {
            num = Math.Abs(num);
            long sum = 0;
            while (num > 0)
            {
                var digit = num % 10;
                if (digit % 2 == 0)
                {
                    sum = sum + digit;
                }
                num /= 10;
            }
            return sum;
        }
    }
}
