namespace P01.Crossroads
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            Queue<string> cars = new Queue<string>();
            Stack<string> carsPassed = new Stack<string>();
            int greenLight = int.Parse(Console.ReadLine());
            int currentGreenLight = greenLight;
            int freeWindow = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            while (input != "END")
            {
                if (input == "green")
                {
                    for (int i = 0; i < greenLight; i++)
                    {
                        if (cars.Count == 0)
                        {
                            greenLight = currentGreenLight;
                            break;
                        }

                        string car = cars.Peek();

                        if (car.Length < greenLight + freeWindow)
                        {
                            cars.Dequeue();
                            carsPassed.Push(car);
                            greenLight -= car.Length;
                        }
                        else
                        {
                            int carHitIndex = Math.Abs(car.Length - 1 - greenLight);
                            char characterHit = car[carHitIndex];
                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{car} was hit at {characterHit}.");
                            return;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{carsPassed.Count} total cars passed the crossroads.");
        }
    }
}