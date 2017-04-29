namespace _02.Randomize_Words
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            var inputWords = Console.ReadLine()
                .Split(' ')
                .ToArray();

            var randomNum = new Random();
            for (int i = 0; i < inputWords.Length; i++)
            {
                var currtentWord = inputWords[i];
                var randomPos = randomNum.Next(0, inputWords.Length);

                var temp = inputWords[randomPos];
                inputWords[randomPos] = currtentWord;
                inputWords[i] = temp;
            }
            foreach (var word in inputWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}
