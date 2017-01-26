namespace Task4
{
    using System;

    class Elevator
    {
        static void Main(string[] args)
        {

            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            double fullCourses =Math.Ceiling( (Double)people / (Double)capacity);
           
            Console.WriteLine(fullCourses);

        }
    }
}
