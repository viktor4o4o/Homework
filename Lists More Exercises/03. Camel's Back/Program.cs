using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Camel_s_Back
{
    class Program
    {
        static void Main(string[] args)
        {
            var numsList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int camelBack = int.Parse(Console.ReadLine());

            int rounds = 0;

            while (numsList.Count > camelBack)
            {
                numsList.RemoveAt(0);
                numsList.RemoveAt(numsList.Count - 1);
                rounds++;
            }
            
            if (rounds == 0)
            {
                Console.WriteLine("already stable: " + string.Join(" ", numsList));
            }
            else
            {
                Console.WriteLine($"{rounds} rounds");
                Console.WriteLine("remaining: " + string.Join(" ", numsList));
            }
        }
    }
}
