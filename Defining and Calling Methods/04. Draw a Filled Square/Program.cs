namespace _04.Draw_a_Filled_Square
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            PrintSquare();
        }
        static void PrintSquare()
        {
            int n = int.Parse(Console.ReadLine());

            PrintHeader(n);
            for (int i = 0; i < n -2; i++)
            {
                PrintBody(n);
            }
            PrintFooter(n);
        }
        static void PrintHeader(int size)
        {
            var header = new string('-', 2 * size);           
            Console.WriteLine($"{header}");
        }
        static void PrintBody(int size)
        {
            var body = string.Empty;
            for (int i = 0; i < size - 1; i++)
            {
                body += @"\/";
            }            
            Console.WriteLine($"-{body}-");
        }
        static void PrintFooter(int size)
        {
            var header = new string('-', 2 * size);
            Console.WriteLine($"{header}");
        }
    }
}
