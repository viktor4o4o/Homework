using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');

            List<string> foundWord = new List<string>();
            List<int> wordCount = new List<int>();

            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];
                if (foundWord.Contains(currentWord))
                {
                    int wordIndex = foundWord.IndexOf(currentWord);
                    wordCount[wordIndex]++;
                }
                else
                {
                    foundWord.Add(currentWord);
                    wordCount.Add(1);
                }
            }
            bool hasSwapped = true;
            while (hasSwapped)
            {
                hasSwapped = false;
                for (int i = 0; i < wordCount.Count - 1; i++)
                {
                    if (wordCount[i] < wordCount[i + 1])
                    {
                        int temp = wordCount[i];
                        wordCount[i] = wordCount[i + i];
                        wordCount[i + 1] = temp;

                        string tempWord = foundWord[i];
                        foundWord[i] = foundWord[i + 1];
                        foundWord[i + 1] = tempWord;

                        hasSwapped = true;
                    }
                }
            }            
            for (int i = 0; i < foundWord.Count; i++)
            {
                double currentPercentage =(wordCount[i] * 100.0) / words.Length;
                Console.WriteLine("{0} -> {1} times ({2:F2}%)", foundWord[i], wordCount[i], currentPercentage);
            }            
        }
    }
}
