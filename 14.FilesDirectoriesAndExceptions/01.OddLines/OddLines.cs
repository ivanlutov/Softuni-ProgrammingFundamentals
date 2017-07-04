using System.IO;
using System.Linq;

namespace _01.OddLines
{
    public class OddLines
    {
        public static void Main()
        {
            string[] inputFile = File.ReadAllLines("input.txt");

            File.WriteAllLines("output.txt",
                         inputFile.Where((line, index) => index % 2 == 1));
        }
    }
}