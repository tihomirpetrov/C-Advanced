namespace P02.StackSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            Stack<int> stackOfNumbers = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            string input = Console.ReadLine().ToLower();

            while (input != "end")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] == "add")
                {
                    stackOfNumbers.Push(int.Parse(tokens[1]));
                    stackOfNumbers.Push(int.Parse(tokens[2]));
                }

                else if (tokens[0] == "remove")
                {
                    int index = int.Parse(tokens[1]);
                    if (stackOfNumbers.Count > index)
                    {
                        for (int i = 0; i < index; i++)
                        {
                            stackOfNumbers.Pop();                            
                        }
                    }
                }

                input = Console.ReadLine().ToLower();
            }       

            Console.WriteLine($"Sum: {stackOfNumbers.Sum()}");
        }
    }
}