using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Letter_Repetition
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var lettersCount = new Dictionary<char, int>();
            foreach (var letter in input)
            {
                if (!lettersCount.ContainsKey(letter))
                {
                    lettersCount[letter] = 0;
                }
                lettersCount[letter]++;
            }
            foreach (var kvp in lettersCount)
            {
                var letter = kvp.Key;
                var count = kvp.Value;
                Console.WriteLine($"{letter} -> {count}");
            }
        }
    }
}
