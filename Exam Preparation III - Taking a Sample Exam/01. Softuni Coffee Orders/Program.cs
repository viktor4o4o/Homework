using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Softuni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal total = 0M;

            for (int i = 0; i < n; i++)
            {
                decimal partialPrice = 0M;
                decimal price = decimal.Parse(Console.ReadLine());
                var format = @"d/M/yyyy";
                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), format, CultureInfo.InvariantCulture);
                var capsules = int.Parse(Console.ReadLine());

                partialPrice = ((((DateTime.DaysInMonth(orderDate.Year, orderDate.Month) * (long)capsules) * price)));
                total += partialPrice;
                Console.WriteLine("The price for the coffee is: ${0:F2}", partialPrice);
            }
            Console.WriteLine("Total: ${0:F2}",total);
        }
    }
}
