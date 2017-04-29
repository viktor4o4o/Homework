using System;
using System.Linq;
 
namespace appendLists
{
    class appendLists
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split('|').ToList();
 
            for (int i = list.Count - 1; i >= 0; i--)
            {
                var token = list[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                Console.Write(String.Join(" ", token) + " ");
            }
 
            Console.WriteLine();
        }
    }
}