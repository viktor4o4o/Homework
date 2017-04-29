namespace _04.Float_or_Integer
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {

            double number = double.Parse(Console.ReadLine());
            if (number is int)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine(Math.Round(number));
            }
        }
    }
}
