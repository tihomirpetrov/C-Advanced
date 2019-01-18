namespace P04.MatrixShuffling
{
    using System;
    using System.Linq;

    class Startup
    {
        public static void Main()
        {
            int[] sizes = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = sizes[0];
            int cols = sizes[1];
            string[][] matrix = new string[rows][];

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = new string[cols];
                matrix[row] = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            while (command[0] != "END")
            {
                if (command[0] != "swap" || command.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                    command = Console.ReadLine().Split().ToArray();
                    continue;
                }

                int row1 = int.Parse(command[1]);
                int col1 = int.Parse(command[2]);
                int row2 = int.Parse(command[3]);
                int col2 = int.Parse(command[4]);

                if (row1 < 0 || row1 >= rows &&
                    col1 < 0 || col1 >= cols &&
                    row2 < 0 || row2 >= rows &&
                    col2 < 0 || col2 >= cols)
                {
                    Console.WriteLine("Invalid input!");
                    command = Console.ReadLine().Split().ToArray();
                    continue;
                }

                string firstElement = matrix[row1][col1];
                string secondElement = matrix[row2][col2];

                matrix[row1][col1] = secondElement;
                matrix[row2][col2] = firstElement;

                Console.WriteLine(string.Join(Environment.NewLine, matrix.Select(r => string.Join(" ", r))));

                command = Console.ReadLine().Split().ToArray();
            }
        }
    }
}