namespace P08.Ranking_2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(':').ToArray();
            Dictionary<string, string> contestPassword = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> userContestPoints = new Dictionary<string, Dictionary<string, int>>();

            while (input[0] != "end of contests")
            {
                string contest = input[0];
                string passwordForContest = input[1];

                if (!contestPassword.ContainsKey(contest))
                {
                    contestPassword.Add(contest, passwordForContest);
                }

                input = Console.ReadLine().Split(':').ToArray();
            }

            string[] input2 = Console.ReadLine().Split("=>").ToArray();

            while (input2[0] != "end of submissions")
            {
                string contest = input2[0];
                string password = input2[1];
                string username = input2[2];
                int points = int.Parse(input2[3]);

                if (contestPassword.ContainsKey(contest) && contestPassword.ContainsValue(password))
                {
                    if (!userContestPoints.ContainsKey(username))
                    {
                        userContestPoints.Add(username, new Dictionary<string, int>());
                        userContestPoints[username].Add(contest, points);
                    }
                    else if (userContestPoints.ContainsKey(username))
                    {
                        if (!userContestPoints[username].ContainsKey(contest))
                        {
                            userContestPoints[username].Add(contest, points);
                        }
                        points = Math.Max(points, userContestPoints[username][contest]);
                    }
                }

                input2 = Console.ReadLine().Split("=>").ToArray();
            }

            var userContestPointsFiltered = userContestPoints.OrderByDescending(x => x.Value.Values.Sum()).Take(1);
            string bestUser = string.Empty;
            int totalPoints = 0;

            foreach (var kvp in userContestPointsFiltered)
            {
                bestUser = kvp.Key;
                foreach (var item in kvp.Value)
                {
                    totalPoints += item.Value;
                }
            }

            Console.WriteLine($"Best candidate is {bestUser} with total {totalPoints} points");
            Console.WriteLine("Ranking:");
            foreach (var user in userContestPoints.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{user.Key} ");
                foreach (var contest in user.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}