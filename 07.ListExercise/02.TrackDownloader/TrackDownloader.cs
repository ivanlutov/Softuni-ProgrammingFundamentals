using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.TrackDownloader
{
    public class TrackDownloader
    {
        public static void Main()
        {
            List<string> blackList = Console.ReadLine().Split().ToList();

            string songs = Console.ReadLine();

            List<string> result = new List<string>();

            while (!songs.Equals("end"))
            {
                bool isContains = false;

                for (int i = 0; i < blackList.Count; i++)
                {
                    if (songs.Contains(blackList[i]))
                    {
                        isContains = true;
                    }
                }
                if (!isContains)
                {
                    result.Add(songs);
                }

                songs = Console.ReadLine();
            }

            result.Sort();

            foreach (var word in result)
            {
                Console.WriteLine(word);
            }
        }
    }
}