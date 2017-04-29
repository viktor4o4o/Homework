namespace _02.Multiply_an_Array_of_Doubles
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            var arraySize = Console.ReadLine().Split(); 
            var numbers = new double[arraySize.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = double.Parse(arraySize[i]);
            }
            var p = double.Parse(Console.ReadLine());
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] *= p;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0} ", numbers[i]);
            }
        }
    }
}
