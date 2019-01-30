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
                string line = reader.ReadLine();

                using (StreamWriter writer = new StreamWriter(@"..\..\..\output.txt"))
                {
                    while (line != null)
                    {

                    }
                }
            }
        }
    }
}