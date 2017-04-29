using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Average_Character_Delimiter
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine()
                .Split(' ')
                .ToList();
            double charResult = 0;
            var countChars = 0;

            for (int i = 0; i < inputLine.Count; i++)
            {
                countChars += inputLine[i].Count();
                double sumOfElement = 0;
                foreach (var element in inputLine[i])
                {
                    sumOfElement += (double)element;
                }
                charResult += sumOfElement;
            }
            double averageSum = charResult / countChars;
            if (averageSum >= 97 && averageSum <= 122)
            {
                averageSum -= 32;
            }
            char delimeter = (char)(averageSum);
            Console.WriteLine(string.Join(delimeter.ToString(), inputLine));
        }
    }
}
