﻿namespace P02.ExcelFunctions_
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int headerRows = int.Parse(Console.ReadLine());
            string[][] table = new string[headerRows][];

            for (int i = 0; i < headerRows; i++)
            {
                string[] rowValues = Console.ReadLine().Split(", ");

                table[i] = rowValues;
            }

            string[] commandArgs = Console.ReadLine().Split();
            string command = commandArgs[0];
            string header = commandArgs[1];

            if (command == "hide")
            {
                int headerIndex = Array.IndexOf(table[0], header);
                
                for (int row = 0; row < table.Length; row++)
                {
                    List<string> lineToPrint = new List<string>();
                    lineToPrint.AddRange(table[row].Take(headerIndex).ToList());
                    lineToPrint.AddRange(table[row].Skip(headerIndex + 1));
                    Console.WriteLine(string.Join(" | ", lineToPrint));
                }
            }
        }
    }
}