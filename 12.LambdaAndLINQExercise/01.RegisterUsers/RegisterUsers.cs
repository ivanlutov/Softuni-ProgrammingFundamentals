using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _01.RegisterUsers
{
    public class RegisterUsers
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var nameAndDate = new Dictionary<string, DateTime>();

            while (!input.Equals("end"))
            {
                var dataLine = input.Split("-> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                var name = dataLine[0];
                DateTime date = DateTime.ParseExact(dataLine[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                if (!nameAndDate.ContainsKey(name))
                {
                    nameAndDate[name] = new DateTime();
                }
                nameAndDate[name] = date;

                input = Console.ReadLine();
            }

            var printDict = nameAndDate
                .Reverse()
                .OrderBy(t => t.Value)
                .Take(5)
                .OrderByDescending(t => t.Value)
                .ToDictionary(t => t.Key, t => t.Value);

            foreach (var name in printDict)
            {
                Console.WriteLine($"{name.Key}");
            }
        }
    }
}