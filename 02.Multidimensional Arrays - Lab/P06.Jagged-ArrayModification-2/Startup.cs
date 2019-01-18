namespace P06.Jagged_ArrayModification_2
{
    using System;
    using System.Linq;

    class Startup
    {
        public static void Main()
        {
            int matrixRows = int.Parse(Console.ReadLine());
            int[][] matrix = new int[matrixRows][];

            for (int i = 0; i < matrixRows; i++)
            {
                int[] currentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                matrix[i] = currentRow;
            }

            string[] command = Console.ReadLine().Split().ToArray();

            while (command[0] != "END")
            {
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                int value = int.Parse(command[3]);

                if (row < 0 || row > matrix.Length - 1 || col < 0 || col > matrix[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    command = Console.ReadLine().Split().ToArray();
                    continue;
                }

                if (command[0] == "Add")
                {
                    matrix[row][col] += value;
                }
                else if (command[0] == "Subtract")
                {
                    matrix[row][col] -= value;
                }

                command = Console.ReadLine().Split().ToArray();
            }

            foreach (var item in matrix)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }
    }
}