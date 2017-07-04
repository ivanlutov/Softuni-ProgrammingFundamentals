using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05.Commits
{
    public class Commit
    {
        public string CommitHash { get; set; }

        public string Message { get; set; }

        public int Additions { get; set; }

        public int Deletions { get; set; }

        public int Counter { get; set; }
    }

    public class Commits
    {
        public static void Main()
        {
            SortedDictionary<string, SortedDictionary<string, List<Commit>>> result = new SortedDictionary<string, SortedDictionary<string, List<Commit>>>();

            string input = Console.ReadLine();

            string pattern = @"(?:https:\/\/github\.com)\/([A-Za-z0-9][\w-]*[A-Za-z0-9])\/([A-Za-z-_]+)\/(?:commit)\/(\b[0-9a-f]{5,40}\b)\,(.*)\,(\d+)\,(\d+)";
            Regex regex = new Regex(pattern);

            int counter = 1;
            while (input != "git push")
            {
                MatchCollection matches = regex.Matches(input);
                Commit currentCommit = new Commit();

                foreach (Match match in matches)
                {
                    var name = match.Groups[1].ToString();
                    var repo = match.Groups[2].ToString();
                    currentCommit.CommitHash = match.Groups[3].ToString();
                    currentCommit.Message = match.Groups[4].ToString();
                    currentCommit.Additions = int.Parse(match.Groups[5].ToString());
                    currentCommit.Deletions = int.Parse(match.Groups[6].ToString());
                    currentCommit.Counter = counter;
                    if (!result.ContainsKey(name))
                    {
                        result[name] = new SortedDictionary<string, List<Commit>>();
                    }
                    if (!result[name].ContainsKey(repo))
                    {
                        result[name][repo] = new List<Commit>();
                    }
                    result[name][repo].Add(currentCommit);
                    counter++;
                }

                input = Console.ReadLine();
            }

            foreach (var name in result)
            {
                Console.WriteLine($"{name.Key}:");
                foreach (var repo in name.Value)
                {
                    var totalAdditionsCount = repo.Value.Select(x => x.Additions).Sum();
                    var totalDeletionsCount = repo.Value.Select(x => x.Deletions).Sum();
                    Console.WriteLine($"  {repo.Key}:");
                    foreach (var item in repo.Value.OrderBy(x => x.Counter))
                    {
                        Console.WriteLine($"    commit {item.CommitHash}: {item.Message} ({item.Additions} additions, {item.Deletions} deletions)");
                    }
                    Console.WriteLine($"    Total: {totalAdditionsCount} additions, {totalDeletionsCount} deletions");
                }
            }
        }
    }
}