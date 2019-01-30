namespace P04.MergeFiles
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            List<string> words = new List<string>();

            using (StreamReader wordReader = new StreamReader(@"..\..\..\FileOne.txt"))
            {
                string line = wordReader.ReadLine();

                while (line != null)
                {
                    string[] splittedLine = line.ToLower().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => x.ToLower()).ToArray();
                    words.AddRange(splittedLine);

                    line = wordReader.ReadLine();
                }
            }

            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!wordsCount.ContainsKey(word))
                {
                    wordsCount[word] = 1;
                }
            }

            using (StreamReader reader = new StreamReader(@"..\..\..\FileTwo.txt"))
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    string symbols = " ";

                    foreach (var @char in line)
                    {
                        if (char.IsPunctuation(@char) && @char != '\'')
                        {
                            symbols += @char;
                        }
                    }

                    string[] splittedLine = line.ToLower().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    foreach (var word in splittedLine)
                    {
                        if (wordsCount.ContainsKey(word))
                        {
                            wordsCount[word]++;
                        }
                    }

                    words.AddRange(splittedLine);

                    line = reader.ReadLine();
                }
            }

            var sortedDictionary = wordsCount.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            using (StreamWriter writer = new StreamWriter(@"..\..\..\result.txt"))
            {
                foreach (var kvp in sortedDictionary)
                {
                    string output = $"{kvp.Key} - {kvp.Value}";
                    writer.WriteLine(output);
                }
            }
        }
    }
}