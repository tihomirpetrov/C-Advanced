namespace P02.Collection
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            ListyIterator<string> listyiterator = null;

            while (input != "END")
            {
                string[] splittedInput = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = splittedInput[0];

                if (command == "Create")
                {
                    listyiterator = new ListyIterator<string>(splittedInput.Skip(1).ToList());
                }

                else if (command == "Move")
                {
                    Console.WriteLine(listyiterator.Move());
                }

                else if (command == "Print")
                {
                    Console.WriteLine(listyiterator.Print());
                }

                else if (command == "HasNext")
                {
                    Console.WriteLine(listyiterator.HasNext());
                }

                else if (command == "PrintAll")
                {
                    foreach (var element in listyiterator)
                    {
                        Console.Write(element + " ");
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}