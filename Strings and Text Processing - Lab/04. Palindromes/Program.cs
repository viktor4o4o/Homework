using System;
using System.Collections.Generic;
using System.Linq;

namespace _04Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ', ',', '?', '!', '.' }, StringSplitOptions.RemoveEmptyEntries);

            var result = new SortedSet<string>();

            foreach (var word in input)
            {
                if (IsPalindrome(word))
                {
                    result.Add(word);
                }
            }
            Console.WriteLine(string.Join(", ", result));
        }
        public static bool IsPalindrome(string value)
        {
            var reversed = value.ToCharArray().Reverse();
            reversed = string.Join("", reversed);
            if (value.Equals(reversed))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}