namespace P03.Bombs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int sizeOfMatrix = int.Parse(Console.ReadLine());
            int[][] matrix = new int[sizeOfMatrix][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }

            string[] coordinates = Console.ReadLine().Split(" ").ToArray();
            Dictionary<int, int> bombIndexes = new Dictionary<int, int>();

            for (int i = 0; i < coordinates.Length; i++)
            {
                int[] cellsWithBombs = coordinates[i].Split(",").Select(int.Parse).ToArray();
                int bombRow = cellsWithBombs[0];
                int bombCol = cellsWithBombs[1];
                int bombNumber = matrix[bombRow][bombCol];
                matrix[bombRow][bombCol] = 0;

                if (bombRow < matrix.Length - 1)
                {
                    if (matrix[bombRow + 1][bombCol] > 0)
                    {
                        matrix[bombRow + 1][bombCol] -= bombNumber;
                    }
                }

                if (bombCol + 1 <= matrix.Length - 1 && matrix[bombRow + 1][bombCol + 1] > 0)
                {
                    matrix[bombRow + 1][bombCol + 1] -= bombNumber;
                }
                if (bombRow > 0)
                {
                    if (matrix[bombRow - 1][bombCol] > 0)
                    {
                        matrix[bombRow - 1][bombCol] -= bombNumber;
                    }

                    if (bombCol - 1 >= 0 && matrix[bombRow - 1][bombCol - 1] > 0)
                    {
                        matrix[bombRow - 1][bombCol - 1] -= bombNumber;
                    }

                    if (bombCol < matrix.Length - 1)
                    {
                        if (matrix[bombRow - 1][bombCol + 1] > 0)
                        {
                            matrix[bombRow - 1][bombCol + 1] -= bombNumber;
                        }
                    }
                }

                if (bombCol > 0)
                {
                    if (matrix[bombRow][bombCol - 1] > 0)
                    {
                        matrix[bombRow][bombCol - 1] -= bombNumber;
                    }
                    if (bombRow < matrix.Length - 1)
                    {
                        if (matrix[bombRow + 1][bombCol - 1] > 0)
                        {
                            matrix[bombRow + 1][bombCol - 1] -= bombNumber;
                        }
                    }
                }
                if (bombCol < matrix.Length - 1)
                {
                    if (matrix[bombRow][bombCol + 1] > 0)
                    {
                        matrix[bombRow][bombCol + 1] -= bombNumber;
                    }
                }
            }

            int count = 0;
            int sum = 0;
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix.Length; col++)
                {
                    if (matrix[row][col] > 0)
                    {
                        sum += matrix[row][col];
                        count++;
                    }
                }
            }

            Console.WriteLine($"Alive cells: {count}");
            Console.WriteLine($"Sum: {sum}");
            foreach (var item in matrix)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }
    }
}