using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.UserLogins
{
    public class UserLogins
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var resultDictionary = new SortedDictionary<string, string>();

            while (!input[0].Equals("login"))
            {
                var name = input[0];
                var password = input[1];

                if (!resultDictionary.ContainsKey(name))
                {
                    resultDictionary[name] = password;
                }

                input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            var inputLogin = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            int allLogins = 0;
            int sucessfullLogins = 0;
            bool isLogin = false;
            while (!inputLogin[0].Equals("end"))
            {
                var name = inputLogin[0].Trim();
                var password = inputLogin[1].Trim();
                isLogin = false;
                allLogins++;

                foreach (var kvp in resultDictionary)
                {
                    if (name.Equals(kvp.Key) && password.Equals(kvp.Value))
                    {
                        isLogin = true;
                        sucessfullLogins++;
                    }
                }

                if (isLogin)
                {
                    Console.WriteLine($"{name}: logged in successfully");
                }
                else
                {
                    Console.WriteLine($"{name}: login failed");
                }

                inputLogin = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            Console.WriteLine($"unsuccessful login attempts: {allLogins - sucessfullLogins}");
        }
    }
}