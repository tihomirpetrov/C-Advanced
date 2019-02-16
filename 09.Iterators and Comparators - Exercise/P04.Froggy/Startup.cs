namespace P04.Froggy
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int[] stoneValues = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Lake lake = new Lake(stoneValues);

            Console.WriteLine(string.Join(", ", lake));
        }
    }
}