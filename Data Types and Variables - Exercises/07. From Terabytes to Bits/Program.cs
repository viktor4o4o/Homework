namespace _07.From_Terabytes_to_Bits
{
    using System;

    
    
        class Program
        {
            static void Main(string[] args)
            {

                 var terabyte = double.Parse(Console.ReadLine());
            
                 decimal bits = (decimal)terabyte * 1024 * 1024 * 1024 * 1024 * 8;

                Console.WriteLine("{0:F0}",bits);

            }
        }
    
}
