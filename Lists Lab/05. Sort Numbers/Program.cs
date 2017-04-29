using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] values = Console.ReadLine().Split(' ');
            List<decimal> nums = new List<decimal>();
            foreach (var num in values)
            {
                nums.Add(decimal.Parse(num));
            }
            nums.Sort();
            Console.WriteLine(string.Join(" <= ",nums));
        }
    }
}
