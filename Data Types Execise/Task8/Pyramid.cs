namespace Task8
{
    using System;
    class Pyramid
    {
        static void Main(string[] args)
        {

            double lenght, width, volume, height ;

            lenght = double.Parse(Console.ReadLine());
            height= double.Parse(Console.ReadLine());
            width = double.Parse(Console.ReadLine());

            Console.Write("Length: ");
            Console.Write("Width: ");
            Console.Write("Height: ");
            volume = (width * height * lenght) / 3;
            Console.WriteLine($"Pyramid Volume: {volume:F2} ");
        }
    }
}
