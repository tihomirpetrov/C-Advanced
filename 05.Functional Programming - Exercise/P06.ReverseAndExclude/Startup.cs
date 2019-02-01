namespace P06.ReverseAndExclude
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse);
            int n = int.Parse(Console.ReadLine());

            Func<int, bool> filter = x => x % n != 0;

            var result = numbers.Reverse().Where(filter);
                                 
            Console.WriteLine(string.Join(" ", result));
        }
    }
}