using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03.UserDatabase
{
    public class UserDatabase
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            var users = new Dictionary<string, string>();
            string logginUsers = null;

            if (!File.Exists("users.txt"))
            {
                File.Create("users.txt").Close();
            }

            var lines = File.ReadAllLines("users.txt");
            foreach (var line in lines)
            {
                var nameAndPassword = line.Split(' ').ToArray();
                var name = nameAndPassword[0];
                var password = nameAndPassword[1];

                users[name] = password;
            }

            while (inputLine != "exit")
            {
                var data = inputLine.Split(' ').ToArray();

                if (data[0] == "register")
                {
                    var username = data[1];
                    var password = data[2];
                    var confirmPassword = data[3];
                    if (users.ContainsKey(username))
                    {
                        Console.WriteLine("The given username already exists.");
                    }
                    else if (password != confirmPassword)
                    {
                        Console.WriteLine("The two passwords must match.");
                    }
                    else
                    {
                        users[username] = password;
                        File.AppendAllText("users.txt", $"{username} {password}" + Environment.NewLine);
                    }
                }
                else if (data[0] == "login")
                {
                    var username = data[1];
                    var password = data[2];

                    if (logginUsers != null)
                    {
                        Console.WriteLine("There is already a logged in user.");
                    }
                    else if (!users.ContainsKey(username))
                    {
                        Console.WriteLine("There is no user with the given username.");
                    }
                    else if (users[username] != password)
                    {
                        Console.WriteLine("The password you entered is incorrect.");
                    }
                    else
                    {
                        logginUsers = $"{username} {password}";
                    }
                }
                else if (data[0] == "logout")
                {
                    if (logginUsers == null)
                    {
                        Console.WriteLine("There is no currently logged in user.");
                    }
                    else
                    {
                        logginUsers = null;
                    }
                }

                inputLine = Console.ReadLine();
            }
        }
    }
}