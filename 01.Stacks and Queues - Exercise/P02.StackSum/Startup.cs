namespace P02.StackSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(input);
            string commandInfo = Console.ReadLine().ToLower();

            while (commandInfo != "end")
            {
                string[] tokens = commandInfo.Split();
                string command = tokens[0].ToLower();

                if (command == "add")
                {
                    for (int i = 1; i < tokens.Length; i++)
                    {
                        int number = int.Parse(tokens[i]);
                        stack.Push(number);
                    }
                }
                else if (command == "remove")
                {
                    int countOfRemovedNums = int.Parse(tokens[1]);

                    if (stack.Count < countOfRemovedNums)
                    {
                        commandInfo = Console.ReadLine().ToLower();
                        continue;
                    }

                    for (int i = 0; i < countOfRemovedNums; i++)
                    {
                        stack.Pop();
                    }
                }

                commandInfo = Console.ReadLine().ToLower();
            }

            var sum = stack.Sum();

            Console.WriteLine($"Sum: {sum}");
        }
    }
}