namespace P07.GroupNumbers
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[][] jagged = new int[3][];
            int[] sizes = new int[3];

            for (int i = 0; i < numbers.Length; i++)
            {
                sizes[Math.Abs(numbers[i] % 3)]++;
            }

            for (int i = 0; i < sizes.Length; i++)
            {
                jagged[i] = new int[sizes[i]];
            }

            int[] indices = new int[3];

            for (int i = 0; i < numbers.Length; i++)
            {
                int reminder = Math.Abs(numbers[i] % 3);
                jagged[reminder][indices[reminder]++] = numbers[i];
            }

            foreach (var item in jagged)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }
    }
}