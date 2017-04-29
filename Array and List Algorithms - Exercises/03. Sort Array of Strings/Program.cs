using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sort_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {

           var array = Console.ReadLine()
                .Split(' ')                
                .ToArray();
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < array.Length-1; i++)
                {
                    var current = array[i];
                    var next = array[i + 1];
                    if ((current.CompareTo(next) == 1))
                    {
                        array[i + 1] = current;
                        array[i] = next;
                        swapped = true;
                    }
                }
            }
            while (swapped);
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
