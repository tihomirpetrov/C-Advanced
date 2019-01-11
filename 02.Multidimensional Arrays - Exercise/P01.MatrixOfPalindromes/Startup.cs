namespace P01.MatrixOfPalindromes
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            int[] firstLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int row = firstLine[0];
            int col = firstLine[1];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"{alphabet[i]}{alphabet[i + j]}{alphabet[0 + i]} ");
                }
                Console.WriteLine();
            }
        }
    }
}