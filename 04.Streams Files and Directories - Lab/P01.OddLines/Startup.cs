namespace P01.OddLines
{
    using System;
    using System.IO;

    public class Startup
    {
        public static void Main()
        {
            using (StreamReader reader = new StreamReader(@"..\..\..\Resources\01. Odd Lines\Input.txt"))
            {
                int counter = 0;

                while (true)
                {
                    string line = reader.ReadLine();

                    if (line == null)
                    {
                        break;
                    }

                    if (counter % 2 != 0)
                    {
                        Console.WriteLine(line);
                    }

                    counter++;
                }                
            }
        }
    }
}