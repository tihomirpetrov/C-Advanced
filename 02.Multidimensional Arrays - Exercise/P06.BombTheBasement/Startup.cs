namespace P06.BombTheBasement
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int[] dimensions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            int[][] matrix = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = new int[cols];
            }

            int[] bombParameters = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int targetRow = bombParameters[0];
            int targetCol = bombParameters[1];
            int radius = bombParameters[2];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    double distance = Math.Sqrt(Math.Pow(row - targetRow, 2) + Math.Pow(col - targetCol, 2));

                    if (distance <= radius)
                    {
                        matrix[row][col] = 1;
                    }
                }
            }

            int[][] secondMatrix = new int[cols][];

            for (int row = 0; row < cols; row++)
            {
                secondMatrix[row] = new int[rows];

                for (int col = 0; col < rows; col++)
                {
                    secondMatrix[row][col] = matrix[col][row];
                }
                secondMatrix[row] = secondMatrix[row].OrderByDescending(x => x).ToArray();
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row][col] = secondMatrix[col][row];
                }                
            }

            Console.WriteLine(string.Join(Environment.NewLine, matrix.Select(r => String.Join("", r))));

            //foreach (var item in matrix)
            //{
            //    Console.WriteLine(string.Join("", item));
            //}
        }
    }
}