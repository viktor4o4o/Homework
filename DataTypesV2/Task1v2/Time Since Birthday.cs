namespace Task1v2
{
    using System;

    class TimeSinceBirthday
    {
        static void Main(string[] args)
        {
            var years = int.Parse(Console.ReadLine());
            var days = years * 365;
            var hours = days * 24;
            var minutes = hours * 60;
            Console.WriteLine("{0} years = {1} days = {2} hours = {3} minutes.", years, days, hours, minutes); 
        }
    }
}
