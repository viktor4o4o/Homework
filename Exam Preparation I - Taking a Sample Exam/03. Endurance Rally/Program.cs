using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            var participants = Console.ReadLine()
                .Split()
                .ToList();
            var trackLayout = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();
            var checkPointLayout = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            foreach (var participant in participants)
            {
                double fuel = participant[0];
                for (int i = 0; i < trackLayout.Count; i++)
                {      
                    var fuelAtEachCheckPoint = trackLayout[i];

                    var raceEnded = fuel <= 0 || i == trackLayout.Count;
                    bool outOfFuel = fuel <= 0;
                    bool endOfTrack = i == trackLayout.Count;

                    if (raceEnded)
                    {
                        if (outOfFuel)
                        {
                            Console.WriteLine($"{participant} - reached {i - 1}");
                        }
                        else if (endOfTrack)
                        {
                            Console.WriteLine($"{participant} - fuel left {fuel}");
                        }
                        break;
                    }

                    var isCheckPoint = checkPointLayout.Contains(i);
                    if (isCheckPoint)
                    {
                        fuel += fuelAtEachCheckPoint;
                    }
                    else
                    {
                        fuel -= fuelAtEachCheckPoint;
                    }
                }
            }          
        }
    }
}
