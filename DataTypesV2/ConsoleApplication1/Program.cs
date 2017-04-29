using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var allNumbers = decimal.Parse(Console.ReadLine());
            decimal product = 1;
            for (int i = 0; i < allNumbers; i++)
            {
                var newNumber = decimal.Parse(Console.ReadLine());
                product = product * newNumber;
            }
            Console.WriteLine(product);
        }
    }
}
