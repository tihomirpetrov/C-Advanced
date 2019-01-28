namespace P02.LineNumbers
{
    using System;
    using System.IO;

    public class Startup
    {
        public static void Main()
        {
            using (StreamReader reader = new StreamReader(@"..\..\..\Resources\02. Line Numbers\Input.txt"))
            {
                using (StreamWriter writer = new StreamWriter(@"..\..\..\Resources\02. Line Numbers\Output.txt"))
                {
                    int counter = 1;

                    while (true)
                    {
                        string line = reader.ReadLine();

                        if (line == null)
                        {
                            break;
                        }

                        line = $"{counter}. {line}";
                        counter++;
                        writer.WriteLine(line);
                    }
                }
            }
        }
    }
}