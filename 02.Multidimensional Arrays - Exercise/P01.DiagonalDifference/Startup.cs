namespace P01.DiagonalDifference
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int sizeOfMatrix = int.Parse(Console.ReadLine());
            int rows = sizeOfMatrix;
            int cols = sizeOfMatrix;
            int[][] matrix = new int[rows][];
            long firstSum = 0;
            long secondSum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                matrix[row] = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            for (int i = 0; i < sizeOfMatrix; i++)
            {
                firstSum += matrix[i][i];
            }

            for (int row = 0, col = sizeOfMatrix - 1; row < sizeOfMatrix; row++, col--)
            {
                secondSum += matrix[row][col];
            }
                    
            long difference = Math.Abs(firstSum - secondSum);
            Console.WriteLine(difference);
        }
    }
}