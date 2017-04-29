using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Array_Symmetry
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                               .Split(' ');
                               

            bool isSymetric = true;

            for (int i = 0; i < words.Length /2; i++)
            {
                var firstWord = words[i];
                var lastWord = words[words.Length - 1 - i];
                if (firstWord != lastWord)
                {
                    isSymetric = false;
                    break;
                }
            }
            if (isSymetric)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
