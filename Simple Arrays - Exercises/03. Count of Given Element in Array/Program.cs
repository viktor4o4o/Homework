using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Count_of_Negative_Elements_in_Array
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine()
            .Split(' ').Select(int.Parse).ToArray();
            int givenNum = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (givenNum == arr[i])
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    
    }
}
