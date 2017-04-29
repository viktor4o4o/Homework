using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamShopping
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new Dictionary<string, int>();

            var line = Console.ReadLine();

            while (line != "shopping time")
            {
                var tokens = line.Split();
                var product = tokens[1];
                var quantity = int.Parse(tokens[2]);

                if (!products.ContainsKey(product))
                {
                    products.Add(product, 0);
                }
                products[product] += quantity;
                line = Console.ReadLine();
            }
            line = Console.ReadLine();
            while (line != "exam time")
            {
                var tokens = line.Split();
                var product = tokens[1];
                var quantity = int.Parse(tokens[2]);

                if (!products.ContainsKey(product))
                {
                    Console.WriteLine("{0} doesn't exist", product);
                }
                else
                {
                    if (products[product] == 0)
                    {
                        Console.WriteLine("{0} out of stock", product);
                    }
                    else
                    {
                        products[product] -= quantity;

                        if (products[product] < 0)
                        {
                            products[product] = 0;
                        }
                    }
                }

                line = Console.ReadLine();
            }
            foreach (var a in products)
            {
                if (a.Value > 0)
                {
                    Console.WriteLine("{0} -> {1}", a.Key, a.Value);
                }
            }
        }
    }
}