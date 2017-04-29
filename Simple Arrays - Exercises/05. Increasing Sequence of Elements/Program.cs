using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Equal_Sequence_of_Elements_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                               .Split(' ')
                               .Select(int.Parse)
                               .ToArray();

            bool areAllBigger = true;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    areAllBigger = false;
                    break;
                }
            }
            if (areAllBigger)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
