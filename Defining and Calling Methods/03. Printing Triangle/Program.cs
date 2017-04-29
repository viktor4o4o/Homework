namespace _03.Printing_Triangle
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            PrintTriangle();
        }
        static void PrintTriangle()
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i <= num; i++)
            {
                PrintLine(1, i);
            }
            for (int i = num - 1; i >= 0; i--)
            {
                PrintLine(1, i);
            }
        }

        static void PrintLine( int start,int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
