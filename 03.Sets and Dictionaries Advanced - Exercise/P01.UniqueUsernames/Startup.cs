namespace P01.UniqueUsernames
{
    using System;
    using System.Collections.Generic;

    class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> usernames = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string username = Console.ReadLine();
                if (!usernames.Contains(username))
                {
                    usernames.Add(username);
                }
            }

            foreach (var name in usernames)
            {
                Console.WriteLine(name);
            }
        }
    }
}