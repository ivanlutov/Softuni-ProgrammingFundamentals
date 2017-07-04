using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SoftUniKaraoke
{
    public class SoftUniKaraoke
    {
        public static void Main()
        {
            var names = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            var songs = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            var namesList = new List<string>();
            var songsList = new List<string>();

            for (int i = 0; i < names.Length; i++)
            {
                namesList.Add(names[i]);
            }
            for (int i = 0; i < songs.Length; i++)
            {
                songsList.Add(songs[i].Trim());
            }

            Dictionary<string, HashSet<string>> namesAndAwards = new Dictionary<string, HashSet<string>>();
            string input = Console.ReadLine();

            while (input != "dawn")
            {
                var tokens = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length > 2)
                {
                    var name = tokens[0].Trim();
                    var song = tokens[1].Trim();
                    var award = tokens[2].Trim();

                    bool isValidSong = false;
                    bool isValidName = false;

                    foreach (var songForCompare in songsList)
                    {
                        if (song == songForCompare)
                        {
                            isValidSong = true;
                        }
                    }

                    foreach (var nameForComapre in namesList)
                    {
                        if (name == nameForComapre)
                        {
                            isValidName = true;
                        }
                    }

                    if (isValidSong && isValidName)
                    {
                        if (!namesAndAwards.ContainsKey(name))
                        {
                            namesAndAwards[name] = new HashSet<string>();
                        }
                        namesAndAwards[name].Add(award);
                    }
                }

                input = Console.ReadLine();
            }

            if (namesAndAwards.Count == 0)
            {
                Console.WriteLine("No awards");
                return;
            }

            foreach (var nameAndAward in namesAndAwards.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{nameAndAward.Key}: {nameAndAward.Value.Count} awards");
                foreach (var award in nameAndAward.Value.OrderBy(x => x))
                {
                    if (nameAndAward.Value.Count == 0)
                    {
                        Console.WriteLine("No awards");
                    }
                    else
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }
        }
    }
}