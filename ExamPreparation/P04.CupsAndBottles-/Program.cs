namespace P04.CupsAndBottles_
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            List<int> cupsCapacity = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> bottlesWithWater = Console.ReadLine().Split().Select(int.Parse).ToList();
            int wastedWater = 0;

            while (cupsCapacity.Count > 0)
            {
                int cup = cupsCapacity[0];
                cupsCapacity.RemoveAt(0);

                while (cup > 0)
                {
                    int bottle = bottlesWithWater[bottlesWithWater.Count - 1];
                    bottlesWithWater.RemoveAt(bottlesWithWater.Count - 1);
                    cup -= bottle;

                    if (bottlesWithWater.Count == 0)
                    {
                        wastedWater += Math.Abs(cup);
                        Console.WriteLine($"Cups: {string.Join(" ", cupsCapacity)}");
                        Console.WriteLine($"Wasted litters of water: {wastedWater}");
                        return;
                    }
                }
                wastedWater += Math.Abs(cup);
            }

            bottlesWithWater.Reverse();
            Console.WriteLine($"Bottles: {string.Join(" ", bottlesWithWater)}");
            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}