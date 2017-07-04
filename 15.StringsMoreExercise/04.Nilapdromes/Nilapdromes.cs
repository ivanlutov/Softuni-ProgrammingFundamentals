using System;

namespace _04.Nilapdromes
{
    public class Nilapdromes
    {
        public static void Main()
        {
            var inputStr = Console.ReadLine();

            while (inputStr != "end")
            {
                string firstStr = inputStr.Substring(0, inputStr.Length / 2);
                string secondStr = inputStr.Remove(0, firstStr.Length);
                string border = string.Empty;
                string core = string.Empty;

                for (int i = 0; i < firstStr.Length; i++)
                {
                    string temp = firstStr.Substring(0, i + 1);

                    if (secondStr.Contains(temp) && temp[temp.Length - 1] == secondStr[secondStr.Length - 1] && temp[0] == secondStr[secondStr.Length - temp.Length])
                    {
                        border = temp;
                    }
                }

                if (border.Length * 2 != inputStr.Length)
                {
                    core = inputStr.Substring(border.Length, inputStr.Length - border.Length * 2);
                }

                if (border == "" || core == "")
                {
                    inputStr = Console.ReadLine();
                    continue;
                }
                else
                {
                    Console.WriteLine($"{core + border + core}");
                    inputStr = Console.ReadLine();
                }
            }
        }
    }
}