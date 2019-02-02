namespace P10.PredicateParty
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            List<string> commingPeople = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            ExecuteCommands(commingPeople);
            PrintCommingList(commingPeople);            
        }

        private static void PrintCommingList(List<string> commingPeople)
        {
            if (commingPeople.Any())
            {
                var names = string.Join(", ", commingPeople);
                Console.WriteLine($"{names} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        private static void ExecuteCommands(List<string> commingPeople)
        {
            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (command[0] != "Party!")
            {
                if (command.Length < 3)
                {
                    command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                    continue;
                }

                switch (command[1])
                {
                    case "StartsWith":
                        ForeachName(command[0], commingPeople, n => n.StartsWith(command[2]));
                        break;
                    case "EndsWith":
                        ForeachName(command[0], commingPeople, n => n.EndsWith(command[2]));
                        break;
                    case "Length":
                        ForeachName(command[0], commingPeople, n => n.Length == int.Parse(command[2]));
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
        }

        private static void ForeachName(string command, List<string> commingPeople, Func<string, bool> condition)
        {
            for (int i = commingPeople.Count - 1; i >= 0; i--)
            {
                if (condition(commingPeople[i]))
                {
                    switch (command)
                    {
                        case "Remove":
                            commingPeople.RemoveAt(i);
                            break;
                        case "Double":
                            commingPeople.Add(commingPeople[i]);
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}