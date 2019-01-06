namespace P02.SumMatrixColumns
{
    using System;
    using System.Linq;
    class StartUp
    {
        public static void Main()
        {
            int[] sizes = Console.ReadLine()
                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(Int32.Parse)
                .ToArray();
            int rows = sizes[0];
            int cols = sizes[1];
            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] columnElements = Console.ReadLine()
                .Split()
                .Select(Int32.Parse)
                .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = columnElements[col];
                }
            }

            for (int i = 0; i < cols; i++)
            {
                int sum = 0;

                for (int j = 0; j < rows; j++)
                {
                    sum += matrix[j, i];
                }

                Console.WriteLine(sum);
            }
        }
    }
}