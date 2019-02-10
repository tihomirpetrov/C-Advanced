namespace P02.GenericBoxOfInteger
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int content = int.Parse(Console.ReadLine());
                Box<int> boxWithInt = new Box<int>(content);
                Console.WriteLine(boxWithInt.ToString());
            }
        }
    }
}