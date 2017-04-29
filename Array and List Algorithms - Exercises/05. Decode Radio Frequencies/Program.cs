using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Decode_Radio_Frequencies
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().ToArray();
            var result = new List<char>();

            for (int i = 0; i < numbers.Length; i++)
            {
                var splitInputLineByDot = numbers[i]
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < splitInputLineByDot.Length; j++)
                {
                    if (splitInputLineByDot[j] != 0)
                    {
                        result.Insert(i, (char)splitInputLineByDot[j]);
                    }
                }
            }
            result.Reverse();
            Console.WriteLine(string.Join("", result));
        }
    }       
    }
}
