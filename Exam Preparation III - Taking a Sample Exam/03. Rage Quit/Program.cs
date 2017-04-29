using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
namespace _03.Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex regex = new Regex(@"(\D+)(\d+)");
            MatchCollection matches = regex.Matches(input);

            StringBuilder result = new StringBuilder();

            foreach (Match match in matches)
            {
                var symbol = match.Groups[1].Value;
                var times = int.Parse(match.Groups[2].Value);
                result.Append(Multiplier(symbol,times).ToUpper());
            }
            int count = result.ToString().Distinct().Count();
            Console.WriteLine($"Unique symbols used: {count}");
            Console.WriteLine(result);
        }
        private static string Multiplier(string symbol, int times)
        {
            StringBuilder partialResult = new StringBuilder();
            for (int i = 0; i < times; i++)
            {
                partialResult.Append(symbol);
            }
            return partialResult.ToString();
        } 
    }
}
