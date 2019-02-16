namespace P03.Stack
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            CustomStack<int> stack = new CustomStack<int>();

            while (input != "END")
            {
                string[] splittedInput = input.Split(" ", 2).ToArray();
                string command = splittedInput[0];

                if (command == "Push")
                {
                    int[] numbers = splittedInput[1].Split(", ").Select(int.Parse).ToArray();
                    stack.Push(numbers);
                }
                else
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.Message);
                    }
                }

                input = Console.ReadLine();
            }

            for (int i = 0; i < 2; i++)
            {
                foreach (var number in stack)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}