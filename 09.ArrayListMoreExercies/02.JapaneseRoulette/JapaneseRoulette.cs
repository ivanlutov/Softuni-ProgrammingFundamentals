using System;
using System.Linq;

namespace _02.Japanese_Roulette
{
    public class JapaneseRoulette
    {
        public static void Main()
        {
            var bullets = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var actions = Console.ReadLine().Split(' ').ToList();

            var bulletIndex = bullets.IndexOf(1);
            bool someoneDied = false;
            int indexOfDeadPlayer = 0;

            for (int i = 0; i < actions.Count; i++)
            {
                string[] commandLine = actions[i].Split(',');
                int strength = int.Parse(commandLine[0]);
                string direction = commandLine[1];

                switch (direction)
                {
                    case "Right":
                        bulletIndex = (bulletIndex + strength) % bullets.Count;
                        break;

                    case "Left":
                        for (int j = 0; j < strength; j++)
                        {
                            bulletIndex--;
                            if (bulletIndex < 0)
                            {
                                bulletIndex = bullets.Count - 1;
                            }
                        }
                        break;
                }

                if (bulletIndex == 2)
                {
                    someoneDied = true;
                    indexOfDeadPlayer = i;
                    break;
                }

                if (bulletIndex == bullets.Count - 1)
                {
                    bulletIndex = 0;
                }
                else
                {
                    bulletIndex++;
                }
            }

            if (someoneDied)
            {
                Console.WriteLine($"Game over! Player {indexOfDeadPlayer} is dead.");
            }
            else
            {
                Console.WriteLine("Everybody got lucky!");
            }
        }
    }
}