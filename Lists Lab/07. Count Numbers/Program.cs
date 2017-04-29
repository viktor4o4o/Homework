using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                          .Split(' ')
                          .Select(int.Parse)
                          .ToList();

            numbers.Sort();

            int count = 1;

            for (int i = 0; i < numbers.Count-1; i++)
            {
                var currentNumber = numbers[i];
                var nextNumber = numbers[i + 1];
                if (currentNumber == nextNumber)
                {
                    count++;
                }
                else
                {
                    Console.WriteLine($"{currentNumber} -> {count}");
                    count = 1;
                }
            }    
            Console.WriteLine($"{numbers[numbers.Count - 1]} -> {count}");
        }
    }
}
