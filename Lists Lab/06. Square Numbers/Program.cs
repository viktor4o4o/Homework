﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                          .Split(' ')
                          .Select(int.Parse)
                          .ToList();

            List<int> result = new List<int>();

            foreach (var number in numbers)
            {
                var square =Math.Sqrt(number);
                if (square == (int)square)
                {
                    result.Add(number);
                }
            }
            result.Sort();
            result.Reverse();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
