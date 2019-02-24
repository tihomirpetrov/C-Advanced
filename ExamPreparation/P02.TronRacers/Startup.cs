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
                if (matrix[row].Contains('f'))
                {
                    firstPlayerRow = row;
                    firstPlayerCol = Array.IndexOf(matrix[row], 'f');
                }
                if (matrix[row].Contains('s'))
                {
                    secondPlayerRow = row;
                    secondPlayerCol = Array.IndexOf(matrix[row], 's');
                }
            }

            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);


            while (true)
            {
                if (matrix[firstPlayerRow][firstPlayerCol] == matrix[secondPlayerRow][secondPlayerCol])
                {
                    break;
                }

                string firstPlayerMovement = input[0];
                string secondPlayerMovement = input[1];
                //matrix[firstPlayerRow][firstPlayerCol] = 'f';
                //matrix[secondPlayerRow][secondPlayerCol] = 's';
                                             
                //for (int row = 0; row < matrix.Length; row++)
                //{
                //    if (matrix[row].Contains('f'))
                //    {
                //        firstPlayerRow = row;
                //        firstPlayerCol = Array.IndexOf(matrix[row], 'f');
                //    }
                //    if (matrix[row].Contains('s'))
                //    {
                //        secondPlayerRow = row;
                //        secondPlayerCol = Array.IndexOf(matrix[row], 's');
                //    }
                //}

                if (firstPlayerMovement == "down")
                {
                    firstPlayerRow++;
                    matrix[firstPlayerRow][firstPlayerCol] = 'f';
                    if (matrix[firstPlayerRow][firstPlayerCol] == matrix[secondPlayerRow][secondPlayerCol])
                    {
                        break;
                    }
                }
                else if (firstPlayerMovement == "up")
                {
                    firstPlayerRow--;
                    matrix[firstPlayerRow][firstPlayerCol] = 'f';
                    if (matrix[firstPlayerRow][firstPlayerCol] == matrix[secondPlayerRow][secondPlayerCol])
                    {
                        break;
                    }
                }
                else if (firstPlayerMovement == "left")
                {
                    firstPlayerCol--;
                    matrix[firstPlayerRow][firstPlayerCol] = 'f';
                    if (matrix[firstPlayerRow][firstPlayerCol] == matrix[secondPlayerRow][secondPlayerCol])
                    {
                        break;
                    }
                }
                else if (firstPlayerMovement == "right")
                {
                    firstPlayerCol++;
                    matrix[firstPlayerRow][firstPlayerCol] = 'f';
                    if (matrix[firstPlayerRow][firstPlayerCol] == matrix[secondPlayerRow][secondPlayerCol])
                    {
                        break;
                    }
                }

                if (secondPlayerMovement == "down")
                {
                    secondPlayerRow++;
                    matrix[secondPlayerRow][secondPlayerCol] = 's';
                    if (matrix[firstPlayerRow][firstPlayerCol] == matrix[secondPlayerRow][secondPlayerCol])
                    {
                        break;
                    }

                }
                else if (secondPlayerMovement == "up")
                {
                    secondPlayerRow--;
                    matrix[secondPlayerRow][secondPlayerCol] = 's';
                    if (matrix[firstPlayerRow][firstPlayerCol] == matrix[secondPlayerRow][secondPlayerCol])
                    {
                        break;
                    }

                }
                else if (secondPlayerMovement == "left")
                {
                    secondPlayerCol--;
                    matrix[secondPlayerRow][secondPlayerCol] = 's';
                    if (matrix[firstPlayerRow][firstPlayerCol] == matrix[secondPlayerRow][secondPlayerCol])
                    {
                        break;
                    }

                }
                else if (secondPlayerMovement == "right")
                {
                    secondPlayerCol++;
                    matrix[secondPlayerRow][secondPlayerCol] = 's';
                    if (matrix[firstPlayerRow][firstPlayerCol] == matrix[secondPlayerRow][secondPlayerCol])
                    {
                        break;
                    }

                }

                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var item in matrix)
            {
                Console.WriteLine(string.Join("", item));
            }
        }
    }
}