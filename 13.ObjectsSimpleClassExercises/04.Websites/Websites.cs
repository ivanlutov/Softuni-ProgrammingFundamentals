using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Websites
{
    public class Website
    {
        public string Host { get; set; }

        public string Domain { get; set; }

        public List<string> Queries { get; set; }
    }

    public class Websites
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            var websiteResult = new List<Website>();

            while (!input.Equals("end"))
            {
                var currentWebsite = ReadWebsite(input);

                websiteResult.Add(currentWebsite);

                input = Console.ReadLine();
            }

            foreach (var website in websiteResult)
            {
                Console.Write($"https://www.{website.Host}.{website.Domain}");
                if (website.Queries.Count > 0)
                {
                    Console.WriteLine($"/query?=[{string.Join("]&[", website.Queries)}]");
                }
            }
        }

        public static Website ReadWebsite(string inputToString)
        {
            var websiteData = inputToString.Split(new char[] { '|', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var host = websiteData[0];
            var domain = websiteData[1];
            var queri = new List<string>();

            if (websiteData.Length > 2)
            {
                var query = websiteData[2].Split(',').ToList();
                queri = query;
            }

            var website = new Website
            {
                Host = host,
                Domain = domain,
                Queries = queri
            };

            return website;
        }
    }
}