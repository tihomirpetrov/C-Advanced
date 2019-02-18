namespace P03.MaximumAndMinimumElement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int nQueries = int.Parse(Console.ReadLine());
            Stack<int> stackElements = new Stack<int>();

            for (int i = 0; i < nQueries; i++)
            {
                int[] types = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int operation = types[0];

                if (operation == 1)
                {
                    int number = types[1];
                    stackElements.Push(number);
                }

                else if (operation == 2)
                {
                    if (stackElements.Count < 1)
                    {
                        continue;
                    }
                    stackElements.Pop();
                }

                else if (operation == 3)
                {
                    if (stackElements.Count > 0)
                    {
                        Console.WriteLine(stackElements.Max());
                    }
                }

                else if (operation == 4)
                {
                    if (stackElements.Count > 0)
                    {
                        Console.WriteLine(stackElements.Min());
                    }
                }
            }

            Console.WriteLine(string.Join(", ", stackElements));
        }
    }
}