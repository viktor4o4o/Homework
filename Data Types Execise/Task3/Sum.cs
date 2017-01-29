namespace Task3
{
    using System;

    class Sum
    {
        static void Main(string[] args)
        {

            var n = decimal.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 0; i < n; i++)
            {
                decimal newNumb = decimal.Parse(Console.ReadLine());
                sum = sum + newNumb;

            }
            Console.WriteLine(sum);
        }
    }
}
