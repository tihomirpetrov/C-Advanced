namespace P05.SquareWithMaximumSum
{
    using System;
    using System.Linq;

    class Startup
    {
        public static void Main()
        {
            int[] sizes = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < colElements.Length; col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            int maxSum = int.MinValue;
            int maxRow = 0;
            int maxCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int currentSum = 0;
                    currentSum += matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }

            for (int i = maxRow; i < maxRow + 2; i++)
            {
                for (int j = maxCol; j < maxCol + 2; j++)
                {
                    //Console.Write(matrix[i,j] + " ");
                    Console.Write(string.Join(" ", matrix[i, j] + " "));
                }
                Console.WriteLine();
            }
            Console.WriteLine(maxSum);
        }
    }
}