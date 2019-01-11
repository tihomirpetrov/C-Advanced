namespace P02.DiagonalDifference
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int sizeOfMatrix = int.Parse(Console.ReadLine());
            long[][] matrix = new long[sizeOfMatrix][];
            long sumFirstDiagonal = 0;
            long sumSecondDiagonal = 0;

            for (int i = 0; i < sizeOfMatrix; i++)
            {
                matrix[i] = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
            }

            for (int i = 0; i < sizeOfMatrix; i++)
            {
                sumFirstDiagonal += matrix[i][i];
            }

            for (int row = 0, col = sizeOfMatrix - 1; row < sizeOfMatrix; row++, col--)
            {
                sumSecondDiagonal += matrix[row][col];
            }
            //Console.WriteLine(sumFirstDiagonal);
            //Console.WriteLine(sumSecondDiagonal);

            //long abs = (Math.Abs(sumFirstDiagonal) - Math.Abs(sumSecondDiagonal));
            Console.WriteLine(Math.Abs(sumFirstDiagonal - sumSecondDiagonal));
        }
    }
}