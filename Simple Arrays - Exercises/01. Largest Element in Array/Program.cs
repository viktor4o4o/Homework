using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Largest_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine());
            var numbers = new int[arraySize];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int max = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (max < numbers[i])
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine(max);
        }
    }
}
