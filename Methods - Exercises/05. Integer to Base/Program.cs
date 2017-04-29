namespace _05.Integer_to_Base
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());
            var converted = IntegerToBase(number, toBase);
            Console.WriteLine(converted);
        }
        static string IntegerToBase(long number, int toBase)
        {
            var result = string.Empty;
            while (number > 0)
            {
                var remaider = number % toBase;
                result = remaider + result;
                number /= toBase;
            }
            return result;
        }
    }
}
