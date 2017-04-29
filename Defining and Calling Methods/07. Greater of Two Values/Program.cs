namespace _07.Greater_of_Two_Values
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            switch (type)
            {
                case "int":
                    {
                        var value1 = int.Parse(Console.ReadLine());
                        var value2 = int.Parse(Console.ReadLine());
                        var greater = Max(value1, value2);
                        Console.WriteLine(greater);
                        break;
                    }
                case "char":
                    {
                        var value1 = char.Parse(Console.ReadLine());
                        var value2 = char.Parse(Console.ReadLine());
                        var greater = Max(value1, value2);
                        Console.WriteLine(greater);
                        break;
                    }
                case "string":
                    {
                        var value1 = Console.ReadLine();
                        var value2 = Console.ReadLine();
                        var greater = Max(value1, value2);
                        Console.WriteLine(greater);
                        break;
                    }
            }
        }
        static int Max(int num1,int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            return num2;
        }
        static char Max(char char1, char char2)
        {
            return (char)Math.Max((char)char1, (char)char2);
        }
        static string Max(string string1, string string2)
        {
            if (string1.CompareTo(string2) >= 0)
            {
                return string1;
            }
            return string2;
        }
    }
}

