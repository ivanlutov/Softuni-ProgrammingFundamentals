using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Files
{
    public class Files
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, long>> inputData = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, long> fileDate = new Dictionary<string, long>();

            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split('\\');
                string fileAndSize = input[input.Length - 1];
                string[] fileInfo = fileAndSize.Split(';');
                string root = input[0];
                string fileName = fileInfo[0];
                long fileSize = long.Parse(fileInfo[1]);

                if (inputData.ContainsKey(root))
                {
                    inputData[root][fileName] = fileSize;
                }
                else
                {
                    fileDate = new Dictionary<string, long>();
                    fileDate[fileName] = fileSize;
                    inputData[root] = fileDate;
                }
            }

            string[] subject = Console.ReadLine().Split();
            string fileTypeSubject = subject[0];
            string rootSubject = subject[2];

            bool areThereResults = false;

            if (inputData.ContainsKey(rootSubject))
            {
                fileDate = inputData[rootSubject]
                .OrderByDescending(id => id.Value)
                .ThenBy(id => id.Key)
                .ToDictionary(id => id.Key, id => id.Value);

                foreach (KeyValuePair<string, long> filePair in fileDate)
                {
                    string[] fileNameAndExtension = filePair.Key.Split('.');
                    if (fileNameAndExtension[fileNameAndExtension.Length - 1].Equals(fileTypeSubject))
                    {
                        areThereResults = true;
                        Console.WriteLine($"{filePair.Key} - {filePair.Value} KB");
                    }
                }
            }

            if (!areThereResults)
            {
                Console.WriteLine("No");
            }
        }
    }
}