namespace P02.DiagonalDifference
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int sizeOfMatrix = int.Parse(Console.ReadLine());
            int[][] matrix = new int[sizeOfMatrix][];
            decimal sumFirstDiagonal = 0;
            decimal sumSecondDiagonal = 0;

            for (int i = 0; i < sizeOfMatrix; i++)
            {
                decimal[] row = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
                sumFirstDiagonal += row[i];
                sumSecondDiagonal += row[sizeOfMatrix - 1 - i];
            }

            //Console.WriteLine(sumFirstDiagonal);
            //Console.WriteLine(sumSecondDiagonal);

            decimal abs = (Math.Abs(sumFirstDiagonal) - Math.Abs(sumSecondDiagonal));
            Console.WriteLine(Math.Abs(abs));
        }
    }
}