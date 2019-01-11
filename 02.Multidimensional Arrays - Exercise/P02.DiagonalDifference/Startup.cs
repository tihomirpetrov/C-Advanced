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

            for (int i = 0; i < sizeOfMatrix; i++)
            {
                int[] row = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }
        }
    }
}