using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Increasing_Crisis
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<int> firstLineOfNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            var resultList = new List<int>(firstLineOfNumbers);

            int index = 0;
            for (int i = 0; i < number - 1; i++)
            {
                List<int> everyNextListOfNumbers = Console.ReadLine()
                            .Split(' ')
                            .Select(int.Parse)
                            .ToList();
                int firstElement = everyNextListOfNumbers[0];
                int smallest = GetSmalertElementByFistIndex(resultList, firstElement);
                Console.WriteLine(smallest);
                for (int j = 0; j < everyNextListOfNumbers.Count; j++)
                {

                }
            }

        }
        static int GetSmalertElementByFistIndex(List<int> resultList, int firstElement)
        {
            int smallest = 0;
            for (int i = resultList.Count - 1; i > 0 ; i--)
            {
                if (resultList[i] < smallest)
                {
                    smallest = resultList[i];
                    break;
                }
            }
            return smallest;
        }
    }
}
