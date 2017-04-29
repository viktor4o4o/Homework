using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            int marathonLenght = int.Parse(Console.ReadLine());
            long runners = long.Parse(Console.ReadLine());
            long averageLapsPerRunner = long.Parse(Console.ReadLine());
            long trackLenght = long.Parse(Console.ReadLine());
            int trackCapacity = int.Parse(Console.ReadLine());
            double moneyPerKm = double.Parse(Console.ReadLine());

            var runnersPerDay = runners;
            if (runners > trackCapacity)
            {
                runnersPerDay = trackCapacity;
            }
            long totalrunners = marathonLenght * runnersPerDay;
            if (totalrunners > runners)
            {
                totalrunners = runners;
            }
            var distanceInKm = (totalrunners * averageLapsPerRunner * trackLenght) / 1000;

            var moneyRaised = distanceInKm * moneyPerKm;
            Console.WriteLine("Money raised: {0:F2}", moneyRaised);
        }
    }
}
