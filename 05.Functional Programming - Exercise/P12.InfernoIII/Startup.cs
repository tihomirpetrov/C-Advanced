namespace P12.InfernoIII
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            List<int> gems = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<string> exclude = new List<string>();
            string filterTypeAndParameter = string.Empty;
            string[] command = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (command[0] != "Forge")
            {
                filterTypeAndParameter = command[1] + ":" + command[2];

                switch (command[0])
                {
                    case "Exclude":
                        exclude.Add(filterTypeAndParameter);
                        break;
                    case "Reverse":
                        if (exclude.Contains(filterTypeAndParameter))
                        {
                            exclude.Remove(filterTypeAndParameter);
                        }
                        break;
                }

                command = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            exclude.Reverse();

            foreach (var filter in exclude)
            {
                string[] filterAndParameter = filter.Split(":");
                string filterType = filterAndParameter[0];
                int parameter = int.Parse(filterAndParameter[1]);

                gems = Exclude(gems, parameter, filterType);
            }

            Console.WriteLine(string.Join(" ", gems));
        }

        private static List<int> Exclude(List<int> gems, int parameter, string filterType)
        {
            for (int i = 0; i < gems.Count; i++)
            {
                int leftNumber = (i == 0) ? 0 : gems[i - 1];
                int rightNumbes = (i == gems.Count - 1) ? 0 : gems[i + 1];
                int sum = gems[i];
                if (filterType.Contains("Left"))
                {
                    sum += leftNumber;
                }

                if (filterType.Contains("Right"))
                {
                    sum += rightNumbes;
                }

                if (sum == parameter)
                {
                    gems.RemoveAt(i);
                    i--;
                }
            }

            return gems;
        }
    }
}