namespace P03.CustomMinFunction
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        public static void Main()
        {
            Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Where(x => x == x.Min()).ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}