namespace P05.SnakeMoves
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int[] dimensionsOfStairs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = dimensionsOfStairs[0];
            int cols = dimensionsOfStairs[1];
            char[][] matrix = new char[rows][];
            char[] snake = Console.ReadLine().ToCharArray();

            Queue<char> snakeQueue = new Queue<char>(snake);

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = new char[cols];
                for (int col = 0; col < cols; col++)
                {
                    char charToAdd = snakeQueue.Dequeue();
                    matrix[row][col] = charToAdd;
                    snakeQueue.Enqueue(charToAdd);
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, matrix.Select(r => String.Join("", r))));
        }
    }
}