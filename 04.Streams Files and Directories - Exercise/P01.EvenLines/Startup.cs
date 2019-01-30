namespace P01.EvenLines
{
    using System;
    using System.IO;

    public class Startup
    {
        public static void Main()
        {
            string specialSymbols = "-.,!?";

            int counter = 0;

            using (StreamReader reader = new StreamReader(@"..\..\..\text.txt"))
            {

                using (StreamWriter writer = new StreamWriter(@"..\..\..\output.txt"))
                {

                    string line = reader.ReadLine();

                    while (line != null)
                    {
                        if (counter % 2 == 0)
                        {
                            if (counter != 0)
                            {
                                writer.WriteLine();
                            }

                            string changedLine = string.Empty;

                            foreach (var @char in line)
                            {
                                if (specialSymbols.Contains(@char))
                                {
                                    changedLine += '@';
                                }
                                else
                                {
                                    changedLine += @char;
                                }
                            }

                            string[] splittedLine = changedLine.Split();

                            Array.Reverse(splittedLine);

                            writer.Write(string.Join(" ", splittedLine));
                        }

                        counter++;

                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}