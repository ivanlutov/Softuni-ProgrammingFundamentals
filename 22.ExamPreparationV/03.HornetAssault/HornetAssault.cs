using System;
using System.Linq;

namespace _03.HornetAssault
{
    public class HornetAssault
    {
        public static void Main()
        {
            var beehives = Console.ReadLine().Split().Select(long.Parse).ToList();
            var hornets = Console.ReadLine().Split().Select(long.Parse).ToList();

            var currentHornet = 0;
            var powerOfHornets = hornets.Sum();

            for (int i = 0; i < beehives.Count; i++)
            {
                if (beehives[i] >= powerOfHornets)
                {
                    beehives[i] -= powerOfHornets;
                    if (currentHornet < hornets.Count)
                    {
                        powerOfHornets -= hornets[currentHornet];
                        currentHornet++;
                    }
                }
                else
                {
                    beehives[i] -= powerOfHornets;
                }
            }

            if (beehives.Any(b => b > 0))
            {
                var result = beehives.Where(b => b > 0).ToList();
                Console.WriteLine(string.Join(" ", result));
            }
            else
            {
                var result = hornets.Skip(currentHornet).ToList();
                Console.WriteLine(string.Join(" ", result));
            }
        }
    }
}