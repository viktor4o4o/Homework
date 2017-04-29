using System;
using System.Linq;

namespace integerInsertion
{
    class integerInsertion
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var input = Console.ReadLine();

            while (input != "end")
            {
                int firstDigit = (input.ToString()[0]) - 48;

                list.Insert(firstDigit, int.Parse(input));

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}