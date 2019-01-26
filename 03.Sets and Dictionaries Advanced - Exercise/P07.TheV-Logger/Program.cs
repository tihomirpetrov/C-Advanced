namespace P07.TheV_Logger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            Dictionary<string, HashSet<string>> vloggersFollow = new Dictionary<string, HashSet<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Statistics")
                {
                    break;
                }

                string[] line = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = line[1];
                string name = line[0];

                switch (command )
                {
                    case "joined":
                        if (!vloggersFollow.ContainsKey(name))
                        {
                            vloggersFollow[name] = new HashSet<string>();
                        }
                        break;
                    case "followed":
                        string name2 = line[2];
                        if (vloggersFollow.ContainsKey(name) && vloggersFollow.ContainsKey(name2) && name != name2)
                        {
                            vloggersFollow[name2].Add(name);
                        }
                        break;
                }
            }

            Dictionary<string, List<int>> nameFollowedFollowing = new Dictionary<string, List<int>>();
            foreach (var kvp in vloggersFollow)
            {
                nameFollowedFollowing[kvp.Key] = new List<int> { 0, 0 };
                nameFollowedFollowing[kvp.Key][0] = kvp.Value.Count;
            }

            foreach (var kvp in nameFollowedFollowing)
            {
                int counter = 0;
                foreach (var kvp1 in vloggersFollow)
                {
                    foreach (var item in kvp1.Value)
                    {
                        if (kvp.Key == item)
                        {
                            counter++;
                        }
                    }
                }

                nameFollowedFollowing[kvp.Key][1] = counter;
            }

            Console.WriteLine($"The V-Logger has a total of {nameFollowedFollowing.Keys.Count()} vloggers in its logs.");
            int count = 1;
            foreach (var kvp in nameFollowedFollowing.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Value[1]))
            {
                Console.WriteLine($"{count}. {kvp.Key} : {kvp.Value[0]} followers, {kvp.Value[1]} following");
                if (count == 1)
                {
                    foreach (var kvp1 in vloggersFollow)
                    {
                        if (kvp.Key == kvp1.Key)
                        {
                            foreach (var item in kvp1.Value.OrderBy(x => x))
                            {
                                Console.WriteLine($"*  {item}");
                            }
                        }
                    }
                }

                count++;
            }
        }
    }
}
