namespace P02.BasicStackOperations
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
            Stack<int> stack = new Stack<int>();
            int[] sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < numbersToPush; i++)
            {
                stack.Push(sequence[i]);
            }

            for (int i = 0; i < numbersToPop; i++)
            {
                stack.Pop();
            }

            for (int i = 0; i < stack.Count; i++)
            {
                if (numbersToPeek == stack.Peek())
                {
                    Console.WriteLine(true);
                }                         
            }
        }
    }
}