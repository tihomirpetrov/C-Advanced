namespace P01.ReverseNumbersWithAStack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            int[] numbers = input.Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();

            foreach (var num in numbers)
            {
                stack.Push(num);
            }

            while (stack.Count != 0)
            {
                Console.Write(stack.Pop());
                Console.Write(' ');
            }
            Console.WriteLine();
        }
    }
}