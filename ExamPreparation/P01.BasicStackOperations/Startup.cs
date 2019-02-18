namespace P01.BasicStackOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int[] nsx = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] numberOfIntegers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int elementsToPush = nsx[0];
            int elementsToPop = nsx[1];
            int elementsToPeek = nsx[2];
            Stack<int> elements = new Stack<int>();

            for (int i = 0; i < elementsToPush; i++)
            {
                elements.Push(numberOfIntegers[i]);
            }

            for (int i = 0; i < elementsToPop; i++)
            {
                elements.Pop();
            }

            if (elements.Count == 0)
            {
                Console.WriteLine("0");
                return;
            }

            if (elements.Contains(elementsToPeek))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(elements.Min());
            }
        }
    }
}