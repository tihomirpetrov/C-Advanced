namespace P03.WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    class Startup
    {
        public static void Main()
        {
            List<string> words = new List<string>();

            using (StreamReader wordReader = new StreamReader(@"..\..\..\words.txt"))
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
                    wordsCount[word] = 0;
                }
            }

            using (StreamReader reader = new StreamReader(@"..\..\..\text.txt"))
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

            using (StreamReader readerResult = new StreamReader(@"..\..\..\expectedResult.txt"))
            {
                bool isSame = true;

                foreach (var kvp in sortedDictionary)
                {
                    string output = $"{kvp.Key} - {kvp.Value}";
                    string line = readerResult.ReadLine();

                    if (output != line)
                    {
                        isSame = false;
                        break;
                    }
                }

                if (isSame)
                {
                    Console.WriteLine(true);
                }
            }
        }
    }
}