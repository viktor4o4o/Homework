using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _01.Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            string format = @"hh\:mm\:ss";
            TimeSpan leavingTime = TimeSpan.ParseExact(Console.ReadLine(), format, CultureInfo.InvariantCulture);
            int neededSteps = int.Parse(Console.ReadLine());
            int timeForEachStep = int.Parse(Console.ReadLine());

            var secondsInADay = 24 * 60 * 60;
            int travelTime = (int)(((double)neededSteps * timeForEachStep) % secondsInADay);

            TimeSpan arrivalTime = leavingTime.Add(new TimeSpan(0, 0, travelTime));
            Console.WriteLine("Time Arrival: {0}", arrivalTime.ToString(format));
        }
    }
}
