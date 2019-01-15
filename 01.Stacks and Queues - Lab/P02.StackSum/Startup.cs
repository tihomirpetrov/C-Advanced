namespace P02.StackSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] command = Console.ReadLine().ToLower().Split();
            Stack<int> stackOfNumbers = new Stack<int>(numbers);

            while (command[0] != "end")
            {
                if (command[0] == "add")
                {
                    for (int i = 1; i < command.Length; i++)
                    {
                        stackOfNumbers.Push(int.Parse(command[i]));
                    }
                }
                else if (command[0] == "remove")
                {
                    int number = int.Parse(command[1]);
                    if (number > stackOfNumbers.Count)
                    {
                        command = Console.ReadLine().ToLower().Split();
                        continue;
                    }

                    for (int i = 0; i < number; i++)
                    {
                        stackOfNumbers.Pop();
                    }
                }

                command = Console.ReadLine().ToLower().Split();
            }

            int sum = stackOfNumbers.Sum();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}