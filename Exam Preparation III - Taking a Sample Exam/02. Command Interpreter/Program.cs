using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Command_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                var inputParams = inputLine.Split(' ');
                var command = inputParams[0];
                switch (command)
                {
                    case "reverse":
                        var reverseStart = int.Parse(inputParams[2]);
                        var reverseCount = int.Parse(inputParams[4]);
                        if (IsValid(list, reverseStart,reverseCount))
                        {
                            Reverse(list, reverseStart, reverseCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;
                    case "sort":
                        var sortStart = int.Parse(inputParams[2]);
                        var sortCount = int.Parse(inputParams[4]);
                        if (IsValid(list, sortStart, sortCount))
                        {
                            Sort(list, sortStart, sortCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;
                    case"rollLeft":
                        int rollLeftCount = int.Parse(inputParams[1]);
                        if (rollLeftCount >=0)
                        {
                            RollLeft(list, rollLeftCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;
                    case"rollRight":
                        int rollRightCount = int.Parse(inputParams[1]);
                        if (rollRightCount >=0)
                        {
                            RollRight(list, rollRightCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;
                }
                inputLine = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", list)}]");
        }
        public static void Reverse(List<string> list , int start , int count)
        {
            list.Reverse(start, count);
        }
        public static void Sort(List<string> list, int start, int count)
        {
            list.Sort(start, count, null);
        }
        public static void RollLeft(List<string> list, int rollLeftCount)
        {
            int rotations = rollLeftCount % list.Count;
            for (int i = 0; i < rotations; i++)
            {
                var firstElement = list[0];
                for (int j = 0; j < list.Count-1; j++)
                {
                    list[j] = list[j + 1];
                }
                list[list.Count - 1] = firstElement;
            }
        }
        public static void RollRight(List<string> list, int rollRightCount)
        {
            int rotations = rollRightCount % list.Count;
            for (int i = 0; i < rotations; i++)
            {
                var lastElement = list[list.Count-1];
                for (int j = list.Count - 1; j > 0; j--)
                {
                    list[j] = list[j - 1];
                }
                list[0] = lastElement;
            }
        }
        public static bool IsValid(List<string> list,int start , int count)
        {
            bool result = start >= 0 &&
                start < list.Count &&
                count >= 0 &&
                (start + count) <= list.Count;
            return result;
        }
    }
}
