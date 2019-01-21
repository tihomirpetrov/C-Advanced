namespace P08.Bombs
{
    using System;
    using System.Linq;

    class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int rows = n;
            int cols = n;
            int[][] matrix = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }

            string input = Console.ReadLine();

            string[] bombCoordinates = input.Split(',', StringSplitOptions.RemoveEmptyEntries).ToArray();
        }
    }
}