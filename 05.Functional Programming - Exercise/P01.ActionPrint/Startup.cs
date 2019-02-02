namespace P01.ActionPrint
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => x).ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}