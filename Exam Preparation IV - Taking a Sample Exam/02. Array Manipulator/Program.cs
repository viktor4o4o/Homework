using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var commandLine = Console.ReadLine();
            while (commandLine != "end")
            {
                var commandLineParams = commandLine.Split();
                var command = commandLineParams[0];
                switch (command)
                {
                    case "exchange":
                        var index = int.Parse(commandLineParams[1]);
                        inputArray = ExchangeArrayElements(inputArray, index);
                        break;
                    case "max":
                    case "min":
                        var maxOrMin = command;
                        var evenOrOdd = commandLineParams[1];
                        FindMaxOrMinEvenOrOddElement(inputArray, maxOrMin, evenOrOdd);
                        break;
                    case "first":
                    case "last":
                        var firstOrLast = command;
                        var count = int.Parse(commandLineParams[1]);
                        evenOrOdd = commandLineParams[2];

                        findFirstOrLastEvenOrOddElement(inputArray, firstOrLast, count, evenOrOdd);
                        break;
                }
                commandLine = Console.ReadLine();
            }
            Console.WriteLine("[{0}]", string.Join(", ", inputArray));
        }
        public static int[] ExchangeArrayElements(int[] inputArray, int index)
        {
            var isValidIdex = index >= 0 && index < inputArray.Length;
            if (!isValidIdex)
            {
                Console.WriteLine("Invalid index");
                return inputArray;
            }
            var leftPart = inputArray.Take(index + 1);
            var rightPart = inputArray.Skip(index + 1);
            var combinedArray = rightPart.Concat(leftPart).ToArray();
            return combinedArray;
        }
        private static void FindMaxOrMinEvenOrOddElement(int[] arr, string maxOrMin, string evenOrOdd)
        {
            var evenOrOddElementsParity = evenOrOdd == "even" ? 0 : 1;
            var evenOrOddElements = arr.Where(a => a % 2 == evenOrOddElementsParity).ToArray();

            if (!evenOrOddElements.Any())
            {
                Console.WriteLine("No matches");
                return;
            }

            var maxOrMinElement = maxOrMin == "max" ? evenOrOddElements.Max() : evenOrOddElements.Min();
            var maxOrMinElementIndex = Array.LastIndexOf(arr, maxOrMinElement);
            Console.WriteLine(maxOrMinElementIndex);

        }
        private static void findFirstOrLastEvenOrOddElement(int[] arr, string firstOrLast, int count, string evenOrOdd)
        {
            if (count > arr.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            var evenOrOddParity = evenOrOdd == "even" ? 0 : 1;
            var evenOrOddElements = arr.Where(a => a % 2 == evenOrOddParity);
            int[] foundElements;
            if (firstOrLast == "first")
            {
                foundElements = evenOrOddElements
                    .Take(count)
                    .ToArray();
            }
            else
            {
                foundElements = evenOrOddElements
                    .Reverse()
                    .Take(count)
                    .Reverse()
                    .ToArray();
            }
            Console.WriteLine("[{0}]", string.Join(", ", foundElements));
        }
    }
}
