using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Ununion_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var primalList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int newListNumber = int.Parse(Console.ReadLine());            

            for (int i = 0; i < newListNumber; i++)
            {
                var newList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

                for (int j = 0; j < newList.Count; j++)
                {
                    if(primalList.Contains(newList[j]))
                    {
                        primalList.Remove(newList[j]);
                    }
                    else
                    {
                        primalList.Add(newList[j]);
                    }
                }
            }
            primalList.Sort();
            Console.WriteLine(string.Join(" ", primalList));
        }
    }
}
