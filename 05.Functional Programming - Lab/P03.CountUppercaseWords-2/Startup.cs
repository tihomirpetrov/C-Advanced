namespace P03.CountUppercaseWords_2
{
    using System;
    using System.Linq;

    class Startup
    {
        public static void Main()
        {
            Func<string, bool> checker = x => x[0] == x.ToUpper()[0];
            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(checker).ToArray();

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}