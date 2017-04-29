namespace _05.Calculate_Triangle_Area
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var area = TriandgleArea(width, height);
            Console.WriteLine(area);
        }
        static double TriandgleArea(double width, double height)
        {
            double area = (width * height) / 2;
            return area;
        }
    }
}
