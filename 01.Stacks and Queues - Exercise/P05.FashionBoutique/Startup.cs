namespace P05.FashionBoutique
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        public static void Main()
        {
            int[] clothesInTheBox = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());
            Stack<int> clothesPrice = new Stack<int>(clothesInTheBox.Reverse());
            int box = 0;
            int sum = 0;

            for (int i = 0; i < clothesInTheBox.Length; i++)
            {
                int clothes = clothesInTheBox[i];
                if (capacity > clothes)
                {
                    if (sum + clothes > capacity)
                    {
                        sum += clothes - capacity;
                        box++;
                    }
                    sum += clothes;
                    clothesPrice.Pop();
                }
            }

            Console.WriteLine(box);
        }
    }
}