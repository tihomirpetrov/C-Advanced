namespace P08.PascalTriangle
{
    using System;
    public class Startup
    {
        public static void Main()
        {
            int initialNumber = int.Parse(Console.ReadLine());
            long[][] jagged = new long[initialNumber][];

            for (int i = 1; i <= initialNumber; i++)
            {
                jagged[i - 1] = new long[i];
                jagged[i - 1][0] = 1;
                jagged[i - 1][jagged[i - 1].Length - 1] = 1;
            }

            for (int row = 2; row < initialNumber; row++)
            {
                for (int col = 1; col < jagged[row].Length - 1; col++)
                {
                    jagged[row][col] = jagged[row - 1][col - 1] + jagged[row - 1][col];
                }
            }

            foreach (var item in jagged)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }
    }
}