using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Dict_Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            var resultDict = new Dictionary<string,int>();
            var line = Console.ReadLine();
            while (line != "end")
            {
                var tokents = line.Split();
                var firstElement = tokents[0];
                var lastElement = tokents[tokents.Length - 1];
                var number = 0;
                if (int.TryParse(lastElement, out number))
                {
                    resultDict[firstElement] = number;
                }
                else
                {
                    if (resultDict.ContainsKey(lastElement))
                    {
                        var referencedValue = resultDict[lastElement];
                        resultDict[firstElement] = referencedValue;
                    }    
                }
                line = Console.ReadLine();
            }
            foreach (var kvp in resultDict)
            {
                var item = kvp.Key;
                var price = kvp.Value;
                Console.WriteLine($"{item} === {price}");
            }
        }
    }
}
