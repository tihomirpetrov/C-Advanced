namespace P02.TronRacers
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int sizeOfMatrix = int.Parse(Console.ReadLine());
            char[][] matrix = new char[sizeOfMatrix][];

            for (int row = 0; row < sizeOfMatrix; row++)
            {
                matrix[row] = Console.ReadLine().ToCharArray();
            }

            int firstPlayerRow = -1;
            int firstPlayerCol = -1;
            int secondPlayerRow = -1;
            int secondPlayerCol = -1;

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == 'f')
                    {
                        firstPlayerRow = row;
                        firstPlayerCol = col;
                    }

                    if (matrix[row][col] == 's')
                    {
                        secondPlayerRow = row;
                        secondPlayerCol = col;
                    }
                }
            }           

            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (true)
            {
                string[] commandLine = Console.ReadLine().Split();
                string firstCommand = commandLine[0];
                string secondCommand = commandLine[1];
                switch (firstCommand)
                {
                    case "up":
                        if (firstPlayerRow > 0)
                        {
                            firstPlayerRow--;
                        }
                        else
                        {
                            firstPlayerRow = sizeOfMatrix - 1;
                        }
                        break;
                    case "down":
                        if (firstPlayerRow < sizeOfMatrix - 1)
                        {
                            firstPlayerRow++;
                        }
                        else
                        {
                            firstPlayerRow = 0;
                        }
                        break;
                    case "left":
                        if (firstPlayerCol > 0)
                        {
                            firstPlayerCol--;
                        }
                        else
                        {
                            firstPlayerCol = matrix[0].Length - 1;
                        }
                        break;
                    case "right":
                        if (firstPlayerCol < matrix[0].Length - 1)
                        {
                            firstPlayerCol++;
                        }
                        else
                        {
                            firstPlayerCol = 0;
                        }
                        break;
                }

                if (matrix[firstPlayerRow][firstPlayerCol] == '*')
                {
                    matrix[firstPlayerRow][firstPlayerCol] = 'f';
                }
                else if (matrix[firstPlayerRow][firstPlayerCol] == 's')
                {
                    matrix[firstPlayerCol][firstPlayerCol] = 'x';
                    break;
                }

                switch (secondCommand)
                {
                    case "up":
                        if (secondPlayerRow > 0)
                        {
                            secondPlayerRow--;
                        }
                        else
                        {
                            secondPlayerRow = sizeOfMatrix - 1;
                        }
                        break;
                    case "down":
                        if (secondPlayerRow < sizeOfMatrix - 1)
                        {
                            secondPlayerRow++;
                        }
                        else
                        {
                            secondPlayerRow = 0;
                        }
                        break;
                    case "left":
                        if (secondPlayerCol > 0)
                        {
                            secondPlayerCol--;
                        }
                        else
                        {
                            secondPlayerCol = matrix[0].Length - 1;
                        }
                        break;
                    case "right":
                        if (secondPlayerCol < matrix[0].Length - 1)
                        {
                            secondPlayerCol++;
                        }
                        else
                        {
                            secondPlayerCol = 0;
                        }
                        break;
                }

                if (matrix[secondPlayerRow][secondPlayerCol] == '*')
                {
                    matrix[secondPlayerRow][secondPlayerCol] = 's';
                }
                else if (matrix[secondPlayerRow][secondPlayerCol] == 'f')
                {
                    matrix[secondPlayerRow][secondPlayerCol] = 'x';
                    break;
                }
            }

            foreach (var item in matrix)
            {
                Console.WriteLine(string.Join("", item));
            }

            input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        }

    }
}
