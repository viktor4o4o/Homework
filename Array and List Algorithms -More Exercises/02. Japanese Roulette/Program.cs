using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Japanese_Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> cilynder = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string[] players = Console.ReadLine().Split(' ');

            bool hasDied = false;

            for (int i = 0; i < players.Length; i++)
            {
                string[] currentPlayerParams = players[i].Split(',');

                int rotations = int.Parse(currentPlayerParams[0]);
                string direction = currentPlayerParams[1];

                if (direction == "Right")
                {                    
                    SpinRight(cilynder, rotations);
                }
                else
                {
                    SpinLeft(cilynder, rotations);
                }

                int bulletIndex = FindBullet(cilynder);

                if (bulletIndex == 2)
                {
                    Console.WriteLine("Game over! Player {0} is dead.", i);
                    hasDied = true;

                    break;
                }
                SpinRight(cilynder, 1);
            }

            if (!hasDied)
            {
                Console.WriteLine("Everybody got lucky!");
            }
        }
        static void SpinRight(List<int> cilynder , int rotations)
        {
            rotations = rotations % cilynder.Count;

            for (int i = 0; i < rotations; i++)
            {
                int lastElement = cilynder[cilynder.Count - 1];

                for (int j = cilynder.Count - 1; j > 0; j--)
                {
                    cilynder[j] = cilynder[j - 1];
                }

                cilynder[0] = lastElement;
            }
        }
        static void SpinLeft(List<int> cilynder, int rotations)
        {
            rotations = rotations % cilynder.Count;

            for (int i = 0; i < rotations; i++)
            {
                int firstElement = cilynder[0];

                for (int j = 0; j < cilynder.Count-1; j++)
                {
                    cilynder[j] = cilynder[j + 1];
                }

                cilynder[cilynder.Count - 1] = firstElement;
            }
        }
        private static int FindBullet(List<int> cilynder)
        {
            int bulletIndex = 0;

            for (int i = 0; i < cilynder.Count; i++)
            {
                if (cilynder[i] == 1)
                {
                    bulletIndex = i;
                    break;
                }
            }

            return bulletIndex;
        }
    }
}
