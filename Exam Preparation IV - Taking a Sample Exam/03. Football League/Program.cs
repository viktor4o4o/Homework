using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Football_League
{
    public class Score
    {
        public decimal Points { get; set; }
        public decimal Goals { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var decryptionKey = Regex.Escape(Console.ReadLine());
            var pattern = $@"^.*(?:{decryptionKey})([a-zA-Z]*)(?:{decryptionKey}).* .*(?:{decryptionKey})([a-zA-Z]*)(?:{decryptionKey}).* (\d+):(\d+)";

            Dictionary<string, Score> dict = new Dictionary<string, Score>();

            var input = Console.ReadLine();
            while (input != "final")
            {
                var match = Regex.Match(input, pattern);
                var team1 = new string(match.Groups[1].Value.ToUpper().Reverse().ToArray());
                var team2 = new string(match.Groups[2].Value.ToUpper().Reverse().ToArray());
                var team1Score = int.Parse(match.Groups[3].Value);
                var team2Score = int.Parse(match.Groups[4].Value);

                if (!dict.ContainsKey(team1))
                {
                    dict[team1] = new Score();
                }
                if (!dict.ContainsKey(team2))
                {
                    dict[team1] = new Score();
                }

                if (team1Score > team2Score)
                {
                    dict[team1].Points += 3;
                }
                else if (team1Score == team2Score)
                {
                    dict[team1].Points += 1;
                    dict[team2].Points += 1;
                }
                else
                {
                    dict[team2].Points += 3;
                }
                dict[team1].Goals += team1Score;
                dict[team2].Goals += team2Score;

                input = Console.ReadLine();
            }
            Console.WriteLine("League standings:");
            var place = 1;
            foreach (var kvp in dict.OrderByDescending(a => a.Value.Points).ThenBy(a => a.Key))
            {
                var teamName = kvp.Key;
                var teamPoints = kvp.Value.Points;
                Console.WriteLine($"{place++}. {teamName} {teamPoints}"); 
            }
            Console.WriteLine("Top 3 scored goals:");

            foreach (var kvp in dict.OrderByDescending(a => a.Value.Goals).ThenBy(a => a.Key).Take(3))
            {
                var teamName = kvp.Key;
                var teamGoals = kvp.Value.Goals;

                Console.WriteLine($"- {teamName} -> {teamGoals}");
            }
        }
    }
}
