namespace P02.BasicQueueOperations
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
            int elementsToEnqueue = nsx[0];
            int elementsToDequeue = nsx[1];
            int elementsToPeek = nsx[2];
            Queue<int> elements = new Queue<int>();

            for (int i = 0; i < elementsToEnqueue; i++)
            {
                elements.Enqueue(numberOfIntegers[i]);
            }

            for (int i = 0; i < elementsToDequeue; i++)
            {
                elements.Dequeue();
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