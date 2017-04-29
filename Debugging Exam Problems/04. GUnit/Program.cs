using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace GUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            var Pattern = new Regex(@"^(?<Classname>[A-Z][a-zA-Z0-9]+) \| (?<Methodname>[A-Z][a-zA-Z0-9]+) \| (?<UnitTestname>[A-Z][a-zA-Z0-9]+)$");

            var Classes = new Dictionary<string, Dictionary<string, List<string>>>();
            var line = Console.ReadLine();

            while (line != "It's testing time!")
            {

                if (Pattern.IsMatch(line))
                {
                    Match Matches = Pattern.Match(line);

                    var ClassName = Matches.Groups["Classname"].Value;
                    var MethodName = Matches.Groups["Methodname"].Value;
                    var UnitTestName = Matches.Groups["UnitTestname"].Value;

                    if (!Classes.ContainsKey(ClassName))
                    {
                        Classes[ClassName] = new Dictionary<string, List<string>>();
                    }
                    if (!Classes[ClassName].ContainsKey(MethodName))
                    {
                        Classes[ClassName][MethodName] = new List<string>();
                    }
                    if (!Classes[ClassName][MethodName].Contains(UnitTestName))
                    {
                        Classes[ClassName][MethodName].Add(UnitTestName);
                    }
                }

                line = Console.ReadLine();

            }

            Dictionary<string, Dictionary<string, List<string>>> SortedClasses = Classes.
                OrderByDescending(x => x.Value.Values.Sum(y => y.Count))
                .ThenBy(x => x.Value.Count)
                .ThenBy(x => x.Key, StringComparer.Ordinal)
                .ToDictionary(x => x.Key, x => x.Value);


            foreach (var ClassEntry in SortedClasses)
            {

                Console.WriteLine(ClassEntry.Key + ':');
                Dictionary<string, List<string>> SortedMethods = ClassEntry.Value
                    .OrderByDescending(x => x.Value.Count)
                    .ThenBy(x => x.Key, StringComparer.Ordinal)
                    .ToDictionary(x => x.Key, x => x.Value);

                foreach (var Method in SortedMethods)
                {

                    Console.WriteLine("##" + Method.Key);

                    List<string> SortedUnits = Method.Value
                        .OrderBy(x => x.Length)
                        .ThenBy(u => u, StringComparer.Ordinal)
                        .ToList();

                    foreach (var UnitTest in SortedUnits)
                    {
                        Console.WriteLine("####" + UnitTest);
                    }
                }
            }
        }
    }
}