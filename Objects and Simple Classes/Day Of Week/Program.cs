namespace Day_Of_Week
{
    using System;
    using System.Globalization;

    public class Program
    {
        public static void Main()
        {
            var dateAsText = Console.ReadLine();
            DateTime exactDate = DateTime.ParseExact(
                dateAsText,
                "d-M-yyyy",
                CultureInfo.InvariantCulture);
            Console.WriteLine(exactDate.DayOfWeek);
        }
    }
}
