using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine()
                       .Split(' ')
                       .Select(int.Parse)
                       .ToList();
            var count = 1;
            var result = new List<int>();

            foreach (var number in num)
            {

                if (number >= 0)
                {
                    result.Add(number);

                }
                if (number < 0)
                {
                    count++;
                    if (count == num.Count)
                    {
                        Console.WriteLine("empty");
                    }
                }
            }
            result.Reverse();

            Console.WriteLine(string.Join("\n", result));
        }
    }    
}
