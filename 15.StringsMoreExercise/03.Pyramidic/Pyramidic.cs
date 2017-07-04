using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Pyramidic
{
    public class Pyramidic
    {
        public static void Main()
        {
            List<string> piramydes = new List<string>();

            int n = int.Parse(Console.ReadLine());
            string[] lines = new string[n];

            for (int i = 0; i < n; i++)
            {
                lines[i] = Console.ReadLine();
            }

            for (int i = 0; i < lines.Length; i++)
            {
                string currentLine = lines[i];

                for (int j = 0; j < currentLine.Length; j++)
                {
                    char currentCharacter = currentLine[j];
                    int layer = 1;
                    string currentPyramide = string.Empty;

                    for (int k = i; k < lines.Length; k++)
                    {
                        string currentLayer = new string(currentCharacter, layer);

                        if (lines[k].Contains(currentLayer))
                        {
                            currentPyramide += currentLayer + Environment.NewLine;
                        }
                        else
                        {
                            break;
                        }

                        layer += 2;
                    }

                    piramydes.Add(currentPyramide.Trim());
                }
            }

            Console.WriteLine(piramydes.OrderByDescending(x => x.Length).First());
        }
    }
}