using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"([$^@#])\1{5,}";
            var ticketRegex = new Regex(pattern);
            var tickets = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;    
                }
                var leftSide = ticket.Substring(0, ticket.Length / 2);
                var rightSide = ticket.Substring(ticket.Length/2);

                var leftmatch = ticketRegex.Match(leftSide);
                var rightmatch = ticketRegex.Match(rightSide);

                if (leftmatch.Success && rightmatch.Success)
                {
                    var winningSymbol = leftmatch.Value[0];
                    var shorterMatch = Math.Min(leftmatch.Length, rightmatch.Length);

                    var jackpot = string.Empty;
                    if (shorterMatch == 10)
                    {
                        jackpot = " Jackpot!";
                    }
                    Console.WriteLine($"ticket \"{ticket}\" - {shorterMatch}{winningSymbol}{jackpot}");
                }
                else
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match"); 
                }
            }
        }
    }
}
