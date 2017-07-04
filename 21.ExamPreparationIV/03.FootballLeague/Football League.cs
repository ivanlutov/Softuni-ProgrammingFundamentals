using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.FootballLeague
{
    public class Score
    {
        public int Scores { get; set; }

        public int Goals { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
            string key = Regex.Escape(Console.ReadLine());
            string command = Console.ReadLine();
            string pattern = $@"^.*(?:{key})(?<firstTeam>[a-zA-Z]*)(?:{key}).* .*(?:{key})(?<secondTeam>[a-zA-Z]*)(?:{key}).* (?<firstTeamGoals>\d+):(?<secondTeamGoals>\d+)$";

            var teams = new Dictionary<string, Score>();

            while (command != "final")
            {
                var match = Regex.Match(command, pattern);

                if (!match.Success)
                {
                    command = Console.ReadLine();
                    continue;
                }

                var firstTeam = new string(match.Groups["firstTeam"].Value.ToUpper().Reverse().ToArray());
                var secondTeam = new string(match.Groups["secondTeam"].Value.ToUpper().Reverse().ToArray());
                var firstTeamGoals = int.Parse(match.Groups["firstTeamGoals"].Value);
                var secondTeamGoals = int.Parse(match.Groups["secondTeamGoals"].Value);

                if (!teams.ContainsKey(firstTeam))
                {
                    teams[firstTeam] = new Score();
                }
                if (!teams.ContainsKey(secondTeam))
                {
                    teams[secondTeam] = new Score();
                }

                if (firstTeamGoals > secondTeamGoals)
                {
                    teams[firstTeam].Scores += 3;
                }
                else if (firstTeamGoals == secondTeamGoals)
                {
                    teams[firstTeam].Scores += 1;
                    teams[secondTeam].Scores += 1;
                }
                else if (firstTeamGoals < secondTeamGoals)
                {
                    teams[secondTeam].Scores += 3;
                }

                teams[firstTeam].Goals += firstTeamGoals;
                teams[secondTeam].Goals += secondTeamGoals;

                command = Console.ReadLine();
            }
            int count = 1;
            Console.WriteLine("League standings:");
            foreach (var team in teams.OrderByDescending(x => x.Value.Scores).ThenBy(x => x.Key))
            {
                var scores = team.Value.Scores;
                Console.WriteLine($"{count++}. {team.Key} {scores}");
            }
            Console.WriteLine("Top 3 scored goals:");
            var firstThree = teams.OrderByDescending(x => x.Value.Goals).ThenBy(x => x.Key).Take(3).ToDictionary(x => x.Key, y => y.Value);
            foreach (var team in firstThree)
            {
                Console.WriteLine($"- {team.Key} -> {team.Value.Goals}");
            }
        }
    }
}