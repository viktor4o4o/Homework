using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Char_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            string result = string.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    result += (char)(text[i] - nums[i]);
                }
                else
                {
                    result += (char)(text[i] + nums[i]);
                }
            }
            Console.WriteLine(result);
        }
    }
}
