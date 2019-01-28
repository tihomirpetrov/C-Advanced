namespace P03.WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>();
            string allWords = @"..\..\..\Resources\03. Word Count\words.txt";
            string[] words = allWords.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            using (StreamReader reader = new StreamReader(@"..\..\..\Resources\03. Word Count\text.txt"))
            {
                string currentLine = reader.ReadLine();

                while (true)
                {
                    if (currentLine == null)
                    {
                        break;
                    }

                    for (int i = 0; i < words.Length; i++)
                    {
                        if (!wordCount.ContainsKey(words[i]))
                        {
                            wordCount.Add(words[i], 1);
                        }

                        else
                        {
                            wordCount[words[i]]++;
                        }                        
                    }
                    currentLine = reader.ReadLine();
                }

                foreach (var item in wordCount.OrderByDescending(key => key.Value))
                {
                    Console.WriteLine($"{item.Key} - {item.Value}");
                }
            }
        }
    }
}