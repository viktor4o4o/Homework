using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1___Sweet_Dessert
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal cash = decimal.Parse(Console.ReadLine());
            int guests = int.Parse(Console.ReadLine());
            decimal bananasPrice = decimal.Parse(Console.ReadLine());
            decimal eggsPrice = decimal.Parse(Console.ReadLine());
            decimal berriesPrice = decimal.Parse(Console.ReadLine());

            var portions = 0;
            if (guests % 6 == 0)
            {
                portions = guests / 6;
            }
            else
            {
                portions = guests / 6 + 1;
            }

            var singlePortionPrice = 2 * bananasPrice + 4 * eggsPrice + 0.2m * berriesPrice;
            decimal price = portions * singlePortionPrice;

            if (cash >= price)
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:F2}lv.", price);
            }
            else
            {
                var neededMoney = price - cash;
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:F2}lv more.", neededMoney);
            }
        }
    }
}
