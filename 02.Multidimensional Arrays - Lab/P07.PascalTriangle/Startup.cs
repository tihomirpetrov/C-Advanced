namespace P07.PascalTriangle
{
    using System;

    class Startup
    {
        public static void Main()
        {
            int startNumber = int.Parse(Console.ReadLine());
            long[][] jaggedArr = new long[startNumber][];

            for (int i = 1; i <= jaggedArr.Length; i++)
            {
                jaggedArr[i - 1] = new long[i];
                jaggedArr[i - 1][0] = 1;
                jaggedArr[i - 1][jaggedArr[i - 1].Length - 1] = 1;
            }

            for (int row = 2; row < startNumber; row++)
            {
                for (int col = 1; col < jaggedArr[row].Length - 1; col++)
                {
                    jaggedArr[row][col] = jaggedArr[row - 1][col - 1] + jaggedArr[row - 1][col];
                }
            }

            foreach (var item in jaggedArr)
            {
                Console.WriteLine(string.Join(" ",item));
            }          
        }
    }
}
