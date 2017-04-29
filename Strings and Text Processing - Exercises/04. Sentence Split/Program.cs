using System;
using System.Text;

class SentenceSplit
{
    static void Main()
    {
        var text = Console.ReadLine();

        var delimiter = Console.ReadLine();

        var resultText = text.Split(new string[] { delimiter }, StringSplitOptions.None);

        var result = new StringBuilder();

        result.Append("[" + string.Join(", ", resultText) + "]");

        Console.WriteLine(result);
    }
}