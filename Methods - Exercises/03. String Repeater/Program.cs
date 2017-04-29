namespace _03.String_Repeater
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            string result = RepeatString(str, count);
            Console.WriteLine(result);
        }
        static string RepeatString(string str , int count)
        {
            string repeatedString = string.Empty;
            for (int i = 0; i < count; i++)
            {
                repeatedString += str;
            }
            return repeatedString;
        }
    }
}
