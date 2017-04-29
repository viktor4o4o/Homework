namespace _16.Tricky_Strings
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {

            var delimiter = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            var emptyString = "";
            var newWord = "";

            for (int i = 0; i < n; i++)
            {
                newWord = Console.ReadLine();
                if (i<n-1)
                {
                    emptyString += newWord;
                    emptyString += delimiter;
                }
                else if(i==n)
                {
                    newWord += newWord;
                }                     
            }

            Console.Write(emptyString);
            Console.WriteLine(newWord);
        }
    }
}
