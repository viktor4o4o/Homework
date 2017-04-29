using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Mixed_Phones
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputline = Console.ReadLine();
            var resultDict = new SortedDictionary<string, decimal>();
            while (inputline != "Over")
            {
                var tokens = inputline.Split(" :".ToCharArray(),
                    StringSplitOptions.RemoveEmptyEntries);

                var firstElement = tokens[0];
                var secondElement = tokens[1];

                var phoneNumber = 0m;
                if (decimal.TryParse(firstElement, out phoneNumber))
                {
                    resultDict[secondElement] = phoneNumber;
                }
                else if (decimal.TryParse(secondElement, out phoneNumber))
                {
                    resultDict[firstElement] = phoneNumber;
                }
                inputline = Console.ReadLine();
            }
            foreach (var kvp in resultDict)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
