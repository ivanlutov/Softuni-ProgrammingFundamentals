using System;
using System.Text.RegularExpressions;

namespace _04.HappinessIndex
{
    public class HappinessIndex
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Regex happinesEmoticons = new Regex(@"(\:\)|\:D|\;\)|\:\*|\:\]|\;\]|\:\}|\;\}|\(\:|\*\:|c\:|\[\:|\[\;)");
            Regex sadnessEmoticons = new Regex(@"(\:\(|D\:|\;\(|\:\[|\;\[|\:\{|\;\{|\)\:|\:c|\]\:|\]\;)");

            int happyCount = happinesEmoticons.Matches(input).Count;
            int sadCount = sadnessEmoticons.Matches(input).Count;
            double happyIndex = happyCount / (double)sadCount;
            string status = string.Empty;

            if (happyIndex >= 2)
            {
                status = ":D";
            }
            else if (happyIndex > 1)
            {
                status = ":)";
            }
            else if (happyIndex == 1)
            {
                status = ":|";
            }
            else if (happyIndex < 1)
            {
                status = ":(";
            }

            Console.WriteLine($"Happiness index: {happyIndex:F2} {status}");
            Console.WriteLine($"[Happy count: {happyCount}, Sad count: {sadCount}]");
        }
    }
}