namespace P06.HotPotato
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            string[] children = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            int n = int.Parse(Console.ReadLine());
            Queue<string> playingChildren = new Queue<string>(children);

            while (playingChildren.Count > 1)
            {
                for (int i = 1; i < n; i++)
                {
                    playingChildren.Enqueue(playingChildren.Dequeue());
                }
                Console.WriteLine($"Removed {playingChildren.Dequeue()}");
            }

            Console.WriteLine($"Last is {playingChildren.Dequeue()}");
        }
    }
}