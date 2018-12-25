namespace P05.HotPotato
{
    using System;
    using System.Collections.Generic;

    class Startup
    {
        public static void Main()
        {
            string[] children = Console.ReadLine().Split();
            int tossLimit = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            Stack<int> stack = new Stack<int>(list);
            Queue<string> queue = new Queue<string>(children);

            while (queue.Count != 1)
            {
                for (int i = 1; i < tossLimit; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }

                Console.WriteLine($"Removed {queue.Dequeue()}");
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}