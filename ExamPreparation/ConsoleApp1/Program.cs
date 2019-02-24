namespace P02.TronRacers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int sizeOfMatrix = int.Parse(Console.ReadLine());
            char[][] matrix = new char[sizeOfMatrix][];
            for (int i = 0; i < sizeOfMatrix; i++)
            {
                matrix[i] = Console.ReadLine().ToCharArray();
            }

            int firstPlayerRow = -1;
            int firstPlayerCol = -1;
            int secondPlayerRow = -1;
            int secondPlayerCol = -1;

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == 'f')
                    {
                        firstPlayerRow = i;
                        firstPlayerCol = j;
                    }

                    if (matrix[i][j] == 's')
                    {
                        secondPlayerRow = i;
                        secondPlayerCol = j;
                    }
                }
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                string firstCommand = input[0];
                string secondCommand = input[1];
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
                    matrix[firstPlayerRow][firstPlayerCol] = 'x';
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
        }
    }
}