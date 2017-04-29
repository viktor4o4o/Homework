using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Rabbit_Hole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> comands = Console.ReadLine()
                .Split(' ')
                .ToList();
            var energy = int.Parse(Console.ReadLine());
            var currentIndex = 0;           
            bool lastBomb = false;

            while (energy > 0)
            {
                string[] pureComands= comands[currentIndex].Split('|');
                string currentComand = pureComands[0];
                lastBomb = false;

                if (currentComand == "RabbitHole")
                {
                    Console.WriteLine("You have 5 years to save Kennedy!");
                    break;
                }
                int value = int.Parse(pureComands[1]);
                switch (currentComand)
                {
                    case "Left":
                        currentIndex = Math.Abs(currentIndex - value) % comands.Count;
                        energy -= value;
                        break;
                    case "Right":
                        currentIndex = (currentIndex + value) % comands.Count;
                        energy -= value;
                        break;
                    case "Bomb":
                        comands.RemoveAt(currentIndex);
                        currentIndex = 0;
                        energy -= value;
                        lastBomb = true;
                        break;                       
                }

                if (comands[comands.Count - 1] != "RabbitHole")
                {
                    comands.RemoveAt(comands.Count - 1);
                }
                comands.Add("Bomb|" + energy);

                if (energy <= 0 && lastBomb)
                {
                    Console.WriteLine("You are dead due to bomb explosion!");
                }
                else if (energy <= 0 && !lastBomb)
                {
                    Console.WriteLine("You are tired. You can't continue the mission.");
                }
            } 
        }
    }
}
