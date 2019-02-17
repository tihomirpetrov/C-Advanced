namespace P02.ExcelFunctions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int headerRows = int.Parse(Console.ReadLine());
            string[][] jaggedMatrix = new string[headerRows - 1][];
            int column = 0;
            List<string> headerRow = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> rowsForPrint = new List<string>();


            for (int row = 0; row < headerRows - 1; row++)
            {
                string[] cols = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                column = cols.Length;
                jaggedMatrix[row] = cols;
            }

            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string header = command[1];
            int index = headerRow.IndexOf(header);

            if (command[0] == "hide")
            {
                Console.WriteLine(string.Join(" | ", headerRow.Where(x => x != header)));
                for (int i = 0; i < jaggedMatrix.Length; i++)
                {
                    Console.WriteLine(string.Join(" | ", jaggedMatrix.Where(x => x[i] != header)));
                }
            }

            else if (command[0] == "sort")
            {
                Console.WriteLine(string.Join(" | ", headerRow));
                foreach (var item in jaggedMatrix.OrderBy(x => x[index]))
                {
                    Console.WriteLine(string.Join(" | ", item));
                }
            }

            else if (command[0] == "filter")
            {
                string value = command[2];
                int rowIndex = -1;
                for (int i = 0; i < jaggedMatrix.Length; i++)
                {
                    for (int j = 0; j < jaggedMatrix[i].Length; j++)
                    {
                        if (jaggedMatrix[i][j] == value)
                        {
                            rowIndex = i;
                        }
                    }
                }

                Console.WriteLine(string.Join(" | ", jaggedMatrix[rowIndex]));
            }
        }
    }
}