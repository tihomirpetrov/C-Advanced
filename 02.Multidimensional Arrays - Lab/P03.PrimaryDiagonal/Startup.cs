namespace P03.PrimaryDiagonal
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
            int[,] matrix = new int[rows, cols];
            int sum = 0;

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

            for (int i = 0; i < sizeOfMatrix; i++)
            {
                sum += matrix[i,i];
            }

            Console.WriteLine(sum);           
        }
    }
}