namespace _06.Increment_Variable
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {

            var imputBytes = int.Parse(Console.ReadLine());
            Console.WriteLine(imputBytes % 256);
            Console.WriteLine("Overflowed {0} times", imputBytes / 256);

        }
    }
}
