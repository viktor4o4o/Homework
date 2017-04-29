using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Count_of_Negative_Elements_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double[] numbers = Console.ReadLine()
                               .Split(' ')
                               .Select(double.Parse)
                               .ToArray();
            
            var p = double.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (p < numbers[i])
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
