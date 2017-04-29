namespace _12.Variable_in_Hexadecimal_Format
{

    using System; 

    class Program
    {
        static void Main(string[] args)
        {

            var inputWord = Console.ReadLine();
            var reformedWord = Convert.ToInt32(inputWord,16);
            Console.WriteLine(reformedWord);

        }
    }
}
