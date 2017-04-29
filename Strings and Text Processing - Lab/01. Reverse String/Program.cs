using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputWord = Console.ReadLine();
            var result = string.Empty;
            for (int i = inputWord.Length-1; i > 0; i--)
            {
                result += inputWord[i];
            }
            result += inputWord[0];
            Console.WriteLine(result);        
        }
    }
}
