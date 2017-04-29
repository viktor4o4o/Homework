using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Replace_a_tag
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"<a.+?href=(.+?)>(.+?)<\/a>";
            var URL = Console.ReadLine();
            var regex = new Regex(pattern);
            var replacement = @"[URL href=$1]$2[/URL]";
            while (URL != "end")
            {
                var result = regex.Replace(URL, replacement);
                Console.WriteLine(result);
                URL = Console.ReadLine();
            }
        }
    }
}
