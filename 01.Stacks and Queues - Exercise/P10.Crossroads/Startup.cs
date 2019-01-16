namespace P10.Crossroads
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            int durationOfGreenLight = int.Parse(Console.ReadLine());
            int saveGreenLight = durationOfGreenLight;
            int durationOfFreeWindow = int.Parse(Console.ReadLine());
            Queue<string> car = new Queue<string>();
            int counter = 0;
            int damageCount = 0;

            string command = Console.ReadLine();

            while (command != "END")
            {
                if (command != "green")
                {
                    car.Enqueue(command);
                }
                else
                {
                    while (car.Count > 0)
                    {
                        string passingCar = car.Peek();
                        if (passingCar.Length <= durationOfGreenLight + durationOfFreeWindow)
                        {
                            car.Dequeue();
                            durationOfGreenLight -= passingCar.Length;
                            counter++;
                        }
                        else
                        {
                            if (durationOfGreenLight > 0)
                            {
                                string damagedCar = passingCar;
                                char hitIndex = damagedCar[durationOfGreenLight + durationOfFreeWindow];
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{damagedCar} was hit at {hitIndex}.");
                                damageCount++;
                            }
                            break;
                        }
                    }
                }
                durationOfGreenLight = saveGreenLight;
                command = Console.ReadLine();
            }

            if (car.Count > 0 && damageCount == 0)
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{counter} total cars passed the crossroads.");
            }
        }
    }
}