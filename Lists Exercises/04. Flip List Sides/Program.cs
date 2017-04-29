using System;
using System.Linq;

namespace flipListSides
{
    class flipListSides
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 1; i < list.Count / 2; i++)
            {
                var oldOne = list[i];
                list[i] = list[list.Count - 1 - i];
                list[list.Count - 1 - i] = oldOne;
            }

            Console.WriteLine(String.Join(" ", list));
        }
    }
}