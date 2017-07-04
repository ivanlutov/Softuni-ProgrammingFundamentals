using System;
using System.IO;
using System.Linq;

namespace _02.HTMLContents
{
    public class HTMLContents
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string title = string.Empty;
            string body = string.Empty;

            while (input != "exit")
            {
                var inputLine = input.Split(' ').ToArray();
                if (inputLine.Length == 2)
                {
                    string tag = inputLine[0];
                    string content = inputLine[1];
                    string result = $"\t<{tag}>{content}</{tag}>";

                    if (tag == "title")
                    {
                        title = result;
                    }
                    else
                    {
                        body += result + Environment.NewLine;
                    }
                }

                input = Console.ReadLine();
            }

            string printResult = $"<!DOCTYPE html>" + Environment.NewLine + "<html>" + Environment.NewLine + "<head>" + Environment.NewLine;
            printResult += title + Environment.NewLine;
            printResult += "</head>" + Environment.NewLine + "<body>" + Environment.NewLine;
            printResult += body;
            printResult += "</body>" + Environment.NewLine + "</html>";

            File.WriteAllText("index.html", printResult);
        }
    }
}