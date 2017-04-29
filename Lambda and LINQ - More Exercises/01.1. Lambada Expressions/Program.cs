using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._1.Lambada_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> lambadas = new Dictionary<string, Dictionary<string, string>>();
            string inputline = Console.ReadLine();
            while (inputline != "lambada")
            {
                string[] tokens = inputline.Split(new[] { ' ', '.', '=', '>' }, StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length > 1)
                {
                    var selector = tokens[0];
                    var selectorObject = tokens[1];
                    var property = tokens[2];

                    if (!lambadas.ContainsKey(selector))
                    {
                        lambadas.Add(selector, new Dictionary<string, string>());
                    }
                    lambadas[selector][selectorObject] = property;
                }
                else
                {
                    lambadas = lambadas.ToDictionary(selector => selector.Key, selecotr => selecotr.Value
                    .ToDictionary(selectorObject => selectorObject.Key, selectorObject => selectorObject.Key + "." + selectorObject.Value));
                }
                inputline = Console.ReadLine();
            }
            lambadas
                .ToList()
                .ForEach(selector => selector.Value
                .ToList()
                .ForEach(selectorObject => Console.WriteLine("{0} => {1}.{2}",
                selector.Key,
                selectorObject.Key,
                selectorObject.Value)));
        }
    }
}
