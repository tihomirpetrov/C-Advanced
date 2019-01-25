namespace P07.TheV_Logger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            Dictionary<string, int> vloggersJoin = new Dictionary<string, int>();
            Dictionary<string, int> vloggersFollow = new Dictionary<string, int>();

            while (input[0] != "Statistics")
            {
                string vloggerName = input[0];
                string action = input[1];

                if (action == "joined")
                {
                    if (!vloggersJoin.ContainsKey(vloggerName))
                    {
                        vloggersJoin.Add(vloggerName, 0);
                        vloggersJoin[vloggerName]++;
                    }


                }
                else if (action == "followed")
                {
                    if (vloggersJoin.ContainsKey(vloggerName))
                    {
                        if (!vloggersFollow.ContainsKey(vloggerName))
                        {
                            vloggersFollow.Add(vloggerName, 0);
                        }
                        vloggersFollow[vloggerName]++;
                    }

                }

                input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            Console.WriteLine($"The V-Logger has a total of {vloggersJoin.Count} vloggers in its logs.");
            foreach (var user in vloggersJoin)
            {
                Console.WriteLine($"{user.Value}. {user.Key} : {user.Value} followers, {vloggersJoin.Count} following");

                foreach (var item in vloggersFollow.Keys)
                {
                    if (user.Key == item)
                    {
                        Console.WriteLine($"* {user.Key}");
                    }
                }
               
            }

            //foreach (var user in vloggersFollow)
            //{
            //    Console.WriteLine($"{user.Key} - {user.Value}");
            //}
        }
    }
}
