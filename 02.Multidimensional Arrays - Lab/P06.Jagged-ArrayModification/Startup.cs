namespace P06.Jagged_ArrayModification
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int matrixRows = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[matrixRows][];

            for (int i = 0; i < matrixRows; i++)
            {
                int[] currentRow = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                jaggedArray[i] = currentRow;
            }

            string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "END")
            {
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                int value = int.Parse(command[3]);

                if (row < 0 || row > jaggedArray.Length - 1 || col < 0 || col > jaggedArray[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    command = Console.ReadLine().Split();
                    continue;
                }

                if (command[0] == "Add")
                {
                    jaggedArray[row][col] += value;
                }
                else if (command[0] == "Subtract")
                {
                    jaggedArray[row][col] -= value;
                }

                command = Console.ReadLine().Split();
            }

            foreach (var item in jaggedArray)
            {
                Console.WriteLine(string.Join(" ",item));
            }
        }
    }
}