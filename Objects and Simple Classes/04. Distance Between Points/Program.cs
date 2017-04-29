namespace _04.Distance_Between_Points
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public class Point
        {
            public double X { get; set; }
            public double Y { get; set; }
        }

        public static void Main()
        {
            var firstPoint = ReadPoint();
            var secondPoint = ReadPoint();                                  // MAIN IS HERE <-------------
            var distance = CalcDistance(firstPoint, secondPoint);
            Console.WriteLine($"{distance:f3}");
        }
        public static Point ReadPoint()
        {
            var pointParts = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            return new Point
            {
                X = pointParts[0],
                Y = pointParts[1]
            };
        }
        public static double CalcDistance(Point p1, Point p2)
        {
            double deltaX = p2.X - p1.X;
            double deltaY = p2.Y - p1.Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }
}
