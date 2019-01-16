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
            int saveCapacity = capacity;
            int box = 1;

            while (clothesPrice.Count > 0)
            {
                if (clothesPrice.Peek() < capacity)
                {
                    capacity -= clothesPrice.Pop();
                }

                else if (clothesPrice.Peek() == capacity)
                {
                    capacity -= clothesPrice.Pop();
                    if (clothesPrice.Count > 0)
                    {
                        box++;
                        capacity = saveCapacity;
                    }
                }

                else
                {
                    box++;
                    capacity = saveCapacity;
                }
            }
                      
            Console.WriteLine(box);
        }
    }
}