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
            int arraySize = int.Parse(Console.ReadLine());
            var numbers = new int[arraySize];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]<0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
