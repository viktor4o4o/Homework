using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _01.Lambada_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {

            String[] rawLamddbas = { "x => x.Key", "object => object.Property" , "object => object.Viktor" };


            Dictionary<string, string> lamdbas = new Dictionary<string, string>();

            foreach (var str in input)
            {
                string key = Regex.Split(str, " => ")[0];
                string value = Regex.Split(str, " => ")[1];

                lamdbas[key] = value;
  
            }

            lamdbas = lamdbas.ToDictionary(pair => pair.Key, pair => pair.Key + "." + pair.Value);

            foreach (var pair in lamdbas)
            {

                Console.WriteLine(pair.Value);

            }




        }
    }
}
