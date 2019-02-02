namespace P13.TriFunction
{
    using System;
    using System.Linq;

    class Startup
    {
        public static void Main()
        {
            int targetCharactersSum = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();

            Func<string, int, bool> isValidWord = (str, num) => str.ToCharArray()
                .Select(ch => (int)ch).Sum() >= num;

            Func<string[], int, Func<string, int, bool>, string> firstName = (arr, num, func) => arr.FirstOrDefault(str => func(str, num));

            string result = firstName(names, targetCharactersSum, isValidWord);
            Console.WriteLine(result);
        }
    }
}