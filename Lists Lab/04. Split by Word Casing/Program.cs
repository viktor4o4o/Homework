using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {            
            string str = Console.ReadLine();
            string[] neshto = str.Split(new char[] { ' ', '.', ';', ':', '!', ',', '(', ')', '"', '\'', '\\', '/', '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> str1 = new List<string>();
            List<string> bigWords = new List<string>();
            List<string> smallWords = new List<string>();
            List<string> randomWords = new List<string>();

            for (int i = 0; i < neshto.Length; i++)
            {
                str1.Add(neshto[i]);
            }
            
            foreach (string str2 in str1)
            {
                int countLowerLetters = 0;
                int countBigLetters = 0;

                for (int i = 0; i < str2.Length; i++)
                {
                    if (str2[i] <= 'z' && str2[i] >= 'a')
                    {
                        countLowerLetters++;
                    }
                    else if (str2[i] <= 'Z' && str2[i] >= 'A')
                    {
                        countBigLetters++;
                    }
                }
                if (countLowerLetters == str2.Length)
                {
                    smallWords.Add(str2);
                }
                else if (countBigLetters == str2.Length)
                {
                    bigWords.Add(str2);
                }
                else
                {
                    randomWords.Add(str2);
                }
            }
            Console.WriteLine("Lower-case: " + string.Join(", ", smallWords));
            Console.WriteLine("Mixed-case: " + string.Join(", ", randomWords));
            Console.WriteLine("Upper-case: " + string.Join(", ", bigWords));                      
        }
    }
}
