namespace P04.BasicQueueOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int numbersToPush = int.Parse(input[0]);
            int numbersToPop = int.Parse(input[1]);
            int numbersToPeek = int.Parse(input[2]);
            Queue<int> queue = new Queue<int>();
            int[] sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < numbersToPush; i++)
            {
                queue.Enqueue(sequence[i]);
            }

            for (int i = 0; i < numbersToPop; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(numbersToPeek))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (queue.Count == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }
            }
        }
    }
}