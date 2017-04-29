using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shoot_List_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            string inputLine = Console.ReadLine();
            int lastRemoved = 0;
            string output = string.Empty;

            while (inputLine != "stop")
            {
                if (inputLine == "bang")
                {
                    if (numbers.Count == 0 )
                    {
                       output = "nobody left to shoot! last one was {0}";
                        break;
                    }
                    int sum = GetSum(numbers);
                    double average = (double) sum / numbers.Count;
                    lastRemoved = ShootElement(numbers, average);
                    DecrementElements(numbers);                  
                }
                else
                {
                    int number = int.Parse(inputLine);
                    numbers.Insert(0, number);
                }
                inputLine = Console.ReadLine();
            }
            if (numbers.Count > 0 && output == string.Empty)
            {
                Console.WriteLine("survivors: ", string.Join(" ", numbers));
            }
            else if(numbers.Count == 0 && output == string.Empty)
            {
                Console.WriteLine("you shot them all.last one standing was {0}", lastRemoved);
            }
            else
            {
                Console.WriteLine(output,lastRemoved);
            }
        }
        static int ShootElement(List<int> numbers, double average)
        {
            var result = 0;
            if (numbers.Count == 1)
            {
                Console.WriteLine("shot {0}", numbers[0]);
                numbers.RemoveAt(0);
                result = numbers[0];
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < average)
                {
                    Console.WriteLine("shot {0}", numbers[i]);
                    numbers.RemoveAt(i);
                    result = numbers[i];
                    break;
                }
            }
            return result;
        }
        static void DecrementElements(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i]--;
            }
        }  
        static int GetSum(List<int> numbers)
        {
            int result = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                result += numbers[i];
            }
            return result;
        }
    }
}
