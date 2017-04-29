namespace _03.Smallest_Element_in_Array
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var arraySize = Console.ReadLine().Split();
            var numbers = new int[arraySize.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(arraySize[i]);
            }

            var samllest = int.MaxValue;    
                        
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers [i]<samllest)
                {
                    samllest = numbers[i];
                }
            }
            Console.WriteLine(samllest);
        }
    }
}
