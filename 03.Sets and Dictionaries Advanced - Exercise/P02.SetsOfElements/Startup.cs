namespace P02.SetsOfElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int[] sets = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int n = sets[0];
            int m = sets[1];
            HashSet<int> nSets = new HashSet<int>();
            HashSet<int> mSets = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                nSets.Add(number);
            }

            for (int i = 0; i < m; i++)
            {
                int number = int.Parse(Console.ReadLine());
                mSets.Add(number);
            }

            foreach (var item in nSets)
            {
                if (mSets.Contains(item))
                {
                    Console.Write($"{item}");
                    Console.Write(' ');
                    //Console.Write($"{string.Join(" ", item)}");
                }                
            }         
        }
    }
}