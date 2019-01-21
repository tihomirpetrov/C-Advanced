namespace P09.Miner
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int rows = n;
            int cols = n;
            char[][] matrix = new char[rows][];

            int playerRow = -1;
            int playerCol = -1;
            int coalLeft = 0;

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = Console.ReadLine().Replace(" ", "").ToCharArray();

                if (matrix[row].Contains('s'))
                {
                    playerRow = row;
                    playerCol = Array.IndexOf(matrix[row], 's');
                    matrix[row][playerCol] = '*';
                }
                coalLeft += matrix[row].Where(c => c == 'c').Count();
            }

            foreach (var command in commands)
            {
                switch (command)
                {
                    case "up": playerRow = playerRow < 0 ? playerRow : playerRow - 1; break;
                    case "down": playerRow = playerRow >= n ? playerRow : playerRow + 1; break;
                    case "left": playerCol = playerCol < 0 ? playerCol : playerCol + 1; break;
                    case "right": playerCol = playerCol >= n ? playerCol : playerCol + 1; break;
                }

                if (matrix[playerRow][playerCol] == 'e')
                {
                    Console.WriteLine($"Game over! ({playerRow}, {playerCol})");
                    return;
                }
                else if (matrix[playerRow][playerCol] == 'c')
                {
                    matrix[playerRow][playerCol] = '*';
                    coalLeft--;

                    if (coalLeft == 0)
                    {
                        Console.WriteLine($"You collected all coals! ({playerRow}, {playerCol})");
                    }
                }
            }

            Console.WriteLine($"{coalLeft} coals left. ({playerRow}, {playerCol})");
        }

        //private static bool IsInMatrix(int row, int col, int length)
        //{
        //    return row >= 0 && row < length && col >= 0 && col < length;
        //}
    }
}