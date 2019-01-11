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
                long[] row = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
                sumFirstDiagonal += row[i];
                sumSecondDiagonal += row[sizeOfMatrix - 1 - i];
            }

            //Console.WriteLine(sumFirstDiagonal);
            //Console.WriteLine(sumSecondDiagonal);

            long abs = (Math.Abs(sumFirstDiagonal) - Math.Abs(sumSecondDiagonal));
            Console.WriteLine(Math.Abs(abs));
        }
    }
}