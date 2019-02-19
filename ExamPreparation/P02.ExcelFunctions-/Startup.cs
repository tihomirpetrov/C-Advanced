namespace P02.ExcelFunctions_
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int headerRows = int.Parse(Console.ReadLine());
            string[][] jaggedMatrix = new string[headerRows][];

            for (int i = 0; i < headerRows; i++)
            {
                string[] rowValues = Console.ReadLine().Split(", ");

                jaggedMatrix[i] = rowValues;
            }

            string[] commandArgs = Console.ReadLine().Split();
            string command = commandArgs[0];
            string header = commandArgs[1];

            if (command == "hide")
            {

            }

        }
    }
}