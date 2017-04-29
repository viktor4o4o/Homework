namespace _06.Math_Power
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            
            double poweredNum = PowerMethod(number, power) ;
            Console.WriteLine(poweredNum);

        }
        static double PowerMethod(double number, int power)
        {
            var result = 1d;
            for (int i = 0; i < power; i++)
            {
                result *= number;
            }
            return result;
        }
    }
}
