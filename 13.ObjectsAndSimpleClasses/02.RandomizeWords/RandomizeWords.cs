using System;
using System.Linq;

namespace _02.RandomizeWords
{
    public class RandomizeWords
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split(' ').ToList();
            var randomGenerator = new Random();

            for (int i = 0; i < words.Count; i++)
            {
                int randomPosition = randomGenerator.Next(0, words.Count);

                string temporary = words[i];
                words[i] = words[randomPosition];
                words[randomPosition] = temporary;
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}