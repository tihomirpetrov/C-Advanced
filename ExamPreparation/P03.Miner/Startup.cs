namespace P03.Miner
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int fieldSize = int.Parse(Console.ReadLine());
            string[] commands = Console.ReadLine().Split().ToArray();
            char[][] gameField = new char[fieldSize][];

            for (int row = 0; row < fieldSize; row++)
            {
                string line = Console.ReadLine();
                string temp = line.Replace(" ", "");
                gameField[row] = temp.ToCharArray();
            }

            int minerRow = -1;
            int minerCol = -1;
            int coalsFound = 0;
                    
            for (int row = 0; row < gameField.Length; row++)
            {
                if (gameField[row].Contains('s'))
                {
                    minerRow = row;
                    minerCol = Array.IndexOf(gameField[row], 's');
                }

                if (gameField[row].Contains('c'))
                {                    
                    for (int col = 0; col < gameField[row].Length; col++)
                    {
                        if (gameField[row][col] == 'c')
                        {
                            coalsFound++;
                        }
                    }
                }
            }

            for (int i = 0; i < commands.Length; i++)
            {

                if (commands[i] == "up")
                {
                    if (minerRow == 0)
                    {
                        continue;
                    }
                    minerRow--;
                }
                else if (commands[i] == "down")
                {
                    if (minerRow == gameField.Length - 1)
                    {
                        continue;
                    }
                    minerRow++;
                }
                else if (commands[i] == "left")
                {
                    if (minerCol == 0)
                    {
                        continue;
                    }
                    minerCol--;
                }
                else if (commands[i] == "right")
                {
                    if (minerCol == gameField.Length - 1)
                    {
                        continue;
                    }
                    minerCol++;
                }

                if (gameField[minerRow][minerCol] == 'e')
                {
                    Console.WriteLine($"Game over! ({minerRow}, {minerCol})");
                    return;
                }
                else if (gameField[minerRow][minerCol] == 'c')
                {
                    coalsFound--;
                    gameField[minerRow][minerCol] = '*';
                    if (coalsFound == 0)
                    {
                        Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol})");
                        return;
                    }                    
                }
            }
           
            Console.WriteLine($"{coalsFound} coals left. ({minerRow}, {minerCol})");
        }
    }
}