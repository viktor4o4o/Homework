using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._Distinct_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(double.Parse).Distinct().ToList();

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
