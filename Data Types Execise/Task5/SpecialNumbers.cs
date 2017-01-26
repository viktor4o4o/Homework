namespace Task5
{
    using System;
    class SpecialNumbers
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                var currentNumb = i;
                var sum = 0;
                foreach (var symbol in currentNumb.ToString())
                {
                    var digit = symbol - '0';
                    sum += digit;

                }

                var result = sum == 5 || sum == 7 || sum == 11;
                Console.WriteLine($"{i} -> {result}"); 
            }

        }
    }
}
