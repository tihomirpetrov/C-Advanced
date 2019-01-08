namespace P04.SymbolInMatrix
{
    using System;
    
    public class Startup
    {
        public static void Main()
        {
            int sizeOfMatrix = int.Parse(Console.ReadLine());
            int rows = sizeOfMatrix;
            int cols = sizeOfMatrix;
            char[,] matrix = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                char[] columnElements = Console.ReadLine().ToCharArray();

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = columnElements[j];
                }
            }

            string symbol = Console.ReadLine();
            bool isSymbol = false;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j].ToString() == symbol)
                    {
                        Console.WriteLine($"({i}, {j})");
                        isSymbol = true;
                        return;
                    }
                }
            }
            if (isSymbol == false)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}