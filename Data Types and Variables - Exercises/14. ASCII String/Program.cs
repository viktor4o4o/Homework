namespace _14.ASCII_String
{
    using System;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int currentNum;
            char currentChar;
            var completeText = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                currentNum = int.Parse(Console.ReadLine());
                currentChar = (char)currentNum;
                completeText.Append(currentChar);

                if (i == n - 1)
                {
                    Console.WriteLine(completeText);

                }

            }
        }
    }
}