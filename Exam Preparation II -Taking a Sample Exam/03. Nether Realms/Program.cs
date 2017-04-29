using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Nether_Realms
{
    public class Demon
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public double Damage { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var demons = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            var result = new SortedDictionary<string, Demon>();

            foreach (var demon in demons)
            {
                var health = 0;
                var healthSymbols = demon
                    .Where(s => !char.IsDigit(s) 
                    && s != '+' 
                    && s != '-' 
                    && s != '*' 
                    && s != '/' 
                    && s != '.');
                foreach (var healthSymbol in healthSymbols)
                {
                    health += healthSymbol;
                }

                var damage = 0.0;
                var regex = new Regex(@"-?\d+\.?\d*");
                var matches = regex.Matches(demon);
                foreach (Match match in matches)
                {
                    var currentNum = double.Parse(match.Value);

                    damage += currentNum;
                }
                var modSymbols = demon
                    .Where(s => s == '*' || s == '/');
                foreach (var mod in modSymbols)
                {
                    if (mod == '*')
                    {
                        damage = damage * 2;
                    }
                    else if (mod == '/')
                    {
                        damage = damage / 2;
                    }
                }

                result.Add(demon, new Demon
                {
                    Name = demon,
                    Health = health,
                    Damage = damage
                });         
            }
            foreach (var demonEntry  in result)
            {
                var demon = demonEntry.Value;
                Console.WriteLine($"{demonEntry.Key} - {demon.Health} health, {demon.Damage:F2} damage");
            }
        }
    }
}
