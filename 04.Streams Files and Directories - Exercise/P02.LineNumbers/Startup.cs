namespace P02.LineNumbers
{
    using System;
    using System.IO;

    class Startup
    {
        public static void Main()
        {
            using (StreamReader reader = new StreamReader(@"..\..\..\text.txt"))
            {
                int counter = 1;

                using (StreamWriter writer = new StreamWriter(@"..\..\..\output.txt"))
                {
                    string line = reader.ReadLine();

                    while (line != null)
                    {
                        int lettersCount = 0;
                        int symbolsCount = 0;

                        foreach (var @char in line)
                        {
                            if (char.IsLetter(@char))
                            {
                                lettersCount++;
                            }
                            else if(char.IsPunctuation(@char))
                            {
                                symbolsCount++;
                            }
                        }

                        writer.WriteLine($"Line {counter}: {line} ({lettersCount})({symbolsCount})");
                        counter++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}