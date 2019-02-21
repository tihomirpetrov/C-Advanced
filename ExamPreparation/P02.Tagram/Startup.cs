namespace P02.Tagram
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> usernameTagLikes = new Dictionary<string, Dictionary<string, int>>();

            while (input != "end")
            {
                string[] inputLine = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                if (inputLine.Length > 1)
                {
                    string username = inputLine[0];
                    string tag = inputLine[1];
                    int likes = int.Parse(inputLine[2]);

                    if (!usernameTagLikes.ContainsKey(username))
                    {
                        usernameTagLikes.Add(username, new Dictionary<string, int>());
                    }
                    if (!usernameTagLikes[username].ContainsKey(tag))
                    {
                        usernameTagLikes[username].Add(tag, 0);
                    }
                    usernameTagLikes[username][tag] = likes;
                }
                else
                {
                    string[] input2 = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string username = input2[1];

                    if (usernameTagLikes.ContainsKey(username))
                    {
                        usernameTagLikes.Remove(username);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var user in usernameTagLikes.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Value.Keys.Count()))
            {
                Console.WriteLine(user.Key);
                foreach (var tag in user.Value)
                {
                    Console.WriteLine($"- {tag.Key}: {tag.Value}");
                }
            }
        }
    }
}