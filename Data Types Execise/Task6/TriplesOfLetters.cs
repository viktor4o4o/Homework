﻿namespace Task6
{
    using System;

    class TriplesOfLetters
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (char i = 'a'; i < n + 'a'; i++)
            {
                for (char j = 'a'; j < n + 'a'; j++)
                {
                    for (char k = 'a'; k < n + 'a'; k++)
                    {
                        Console.WriteLine($"{i}{j}{k}");
                    }
                }
            }
        }
    }
}
