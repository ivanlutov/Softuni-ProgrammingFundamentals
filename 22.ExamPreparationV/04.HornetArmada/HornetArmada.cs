using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.HornetArmada
{
    public class HornetArmada
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var legionByActivity = new Dictionary<string, long>();
            var legionByTypeAndCount = new Dictionary<string, Dictionary<string, long>>();

            for (int i = 0; i < n; i++)
            {
                string commandLine = Console.ReadLine();
                var tokens = commandLine.Split(new char[] { '=', '-', '>', ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var lastActivity = long.Parse(tokens[0]);
                var legionName = tokens[1];
                var soldierType = tokens[2];
                var soldierCount = long.Parse(tokens[3]);

                if (!legionByTypeAndCount.ContainsKey(legionName))
                {
                    legionByTypeAndCount[legionName] = new Dictionary<string, long>();
                }
                if (!legionByTypeAndCount[legionName].ContainsKey(soldierType))
                {
                    legionByTypeAndCount[legionName][soldierType] = 0;
                }
                legionByTypeAndCount[legionName][soldierType] += soldierCount;

                if (!legionByActivity.ContainsKey(legionName))
                {
                    legionByActivity[legionName] = lastActivity;
                }
                if (lastActivity > legionByActivity[legionName])
                {
                    legionByActivity[legionName] = lastActivity;
                }
            }

            string command = Console.ReadLine();

            if (command.Contains("\\"))
            {
                var tokens = command.Split('\\').ToArray();
                var activity = long.Parse(tokens[0]);
                var soldierType = tokens[1];
                var result = legionByTypeAndCount
                    .Where(s => s.Value.ContainsKey(soldierType))
                    .OrderByDescending(s => s.Value[soldierType])
                    .ToDictionary(x => x.Key, y => y.Value);
                foreach (var legion in result)
                {
                    if (legionByActivity[legion.Key] < activity)
                    {
                        Console.WriteLine($"{legion.Key} -> {legionByTypeAndCount[legion.Key][soldierType]}");
                    }
                }
            }
            else
            {
                var soldierType = command;

                foreach (var legion in legionByActivity.OrderByDescending(x => x.Value))
                {
                    if (legionByTypeAndCount[legion.Key].ContainsKey(soldierType))
                    {
                        Console.WriteLine($"{legion.Value} : {legion.Key}");
                    }
                }
            }
        }
    }
}