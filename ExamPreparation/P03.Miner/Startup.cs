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
                gameField[row] = Console.ReadLine().ToCharArray();
            }

            int minerRow = -1;
            int minerCol = -1;
            for (int row = 0; row < gameField.Length; row++)
            {
                if (gameField[row].Contains('s'))
                {
                    minerRow = row;
                    minerCol = Array.IndexOf(gameField[row], 's');
                }
            }
            


            for (int i = 0; i < commands.Length; i++)
            {

                if (commands[i] == "up")
                {

                }
                else if (commands[i] == "down")
                {

                }
                else if (commands[i] == "left")
                {

                }
                else if (commands[i] == "right")
                {

                }


            }

            foreach (var item in gameField)
            {
                Console.WriteLine(string.Join("", item));
            }
        }
    }
}
