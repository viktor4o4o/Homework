using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            var participants = Console.ReadLine()
                .Split(',')
                .Select(a => a.Trim())
                 .ToArray();
            var songs = Console.ReadLine()
                .Split(',')
                .Select(a => a.Trim())
                .ToArray();

            var partcipantAwards = new Dictionary<string, SortedSet<string>>();

            var input = Console.ReadLine();

            while (input != "dawn")
            {
                var tokens = input
                    .Split(',')
                    .Select(a => a.Trim())
                    .ToArray();
                var participant = tokens[0];
                var song = tokens[1];
                var award = tokens[2];

                if (songs.Contains(song) && participants.Contains(participant))
                {
                    if (!partcipantAwards.ContainsKey(participant))
                    {
                        partcipantAwards[participant] = new SortedSet<string>();
                    }
                    partcipantAwards[participant].Add(award);
                }
                input = Console.ReadLine();
            }

            if (partcipantAwards.Count == 0)
            {
                Console.WriteLine("No awards");
                return;
            }

            var sortedParticipantAwards = partcipantAwards
                .OrderByDescending(a => a.Value.Count)
                .ThenBy(a => a.Key)
                .ToDictionary(a => a.Key, a => a.Value);

            foreach (var participantAward in sortedParticipantAwards)
            {
                var participant = participantAward.Key;
                var awards = participantAward.Value;

                Console.WriteLine($"{participant}: {awards.Count} awards");
                foreach (var award in awards)
                {
                    Console.WriteLine($"--{award}");
                }
            }
        }
    }
}
