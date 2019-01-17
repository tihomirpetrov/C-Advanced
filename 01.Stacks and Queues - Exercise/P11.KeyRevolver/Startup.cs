namespace P11.KeyRevolver
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int sizeOfGunBarrel = int.Parse(Console.ReadLine());
            int[] bullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] locks = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int valueOfIntelligence = int.Parse(Console.ReadLine());
            Stack<int> bulletsStack = new Stack<int>(bullets);
            Queue<int> locksQueue = new Queue<int>(locks);


            while (bulletsStack.Count > 0 || locksQueue.Count > 0)
            {
                //if (bulletsStack.Peek() )
                {

                }
            }
        }
    }
}