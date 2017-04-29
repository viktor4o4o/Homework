using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phonenumbers = Console.ReadLine().Split(' ');
            string[] names = Console.ReadLine().Split(' ');

            string inputLine = Console.ReadLine();

            while (inputLine != "done")
            {
                PrintElement(names, phonenumbers, inputLine);

                inputLine = Console.ReadLine();
            }            
        }
        private static void PrintElement(string[] names, string[] phonenumbers, string inputLine)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == inputLine)
                {
                    Console.WriteLine("{0} -> {1}", names[i], phonenumbers[i]);
                }
            }    
        }
    }
}
