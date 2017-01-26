namespace Circle_Area
{
    using System;

    class CircleArea
    {
        static void Main(string[] args)
        {
            var radius = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F12}", Math.PI*radius*radius );
        }
    }
}
