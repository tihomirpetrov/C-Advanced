namespace P01.Socks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            List<int> leftSocks = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> rightSocks = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> socks = new List<int>();
            int biggestPair = 0;

            while (leftSocks.Count > 0 && rightSocks.Count > 0)
            {
                if (leftSocks[leftSocks.Count - 1] == rightSocks[0])
                {
                    leftSocks[leftSocks.Count - 1] += 1;
                    rightSocks.Remove(rightSocks[0]);
                }

                else if (leftSocks[leftSocks.Count - 1] < rightSocks[0])
                {
                    leftSocks.RemoveAt(leftSocks.Count - 1);
                }

                else/* if (leftSocks[leftSocks.Count - 1] > rightSocks[0])*/
                {
                    socks.Add(leftSocks[leftSocks.Count - 1] + rightSocks[0]);
                    biggestPair = Math.Max(leftSocks[leftSocks.Count - 1] + rightSocks[0], biggestPair);
                    leftSocks.RemoveAt(leftSocks.Count - 1);
                    rightSocks.RemoveAt(0);
                }
            }

            Console.WriteLine(biggestPair);
            Console.WriteLine(string.Join(" ", socks));
        }
    }
}