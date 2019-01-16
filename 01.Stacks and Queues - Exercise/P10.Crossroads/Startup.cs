namespace P10.Crossroads
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int durationOfGreenLight = int.Parse(Console.ReadLine());
            int durationOfFreeWindow = int.Parse(Console.ReadLine());
            int saveGreenLight = durationOfGreenLight;
            int saveFreeWindow = durationOfFreeWindow;

            Queue<string> car = new Queue<string>();
            int counter = 0;        
            int greenLightLeft = 0;

            string command = Console.ReadLine();

            while (true)
            {
                if (command == "END")
                {
                    Console.WriteLine("Everyone is safe.");
                    Console.WriteLine($"{counter} total cars passed the crossroads.");
                    break;
                }

                if (command == "green")
                {
                    durationOfGreenLight = saveGreenLight;
                    durationOfFreeWindow = saveFreeWindow;

                    while (car.Any())
                    {
                        if (durationOfGreenLight > 0)
                        {
                            greenLightLeft = durationOfGreenLight - car.Peek().Length;
                        }
                        else
                        {
                            break;
                        }

                        if (greenLightLeft >= 0)
                        {
                            counter++;
                            car.Dequeue();
                            if (car.Count > 0)
                            {
                                durationOfGreenLight = greenLightLeft;
                            }
                        }

                        else
                        {
                            greenLightLeft = durationOfGreenLight - car.Peek().Length + durationOfFreeWindow;

                            if (greenLightLeft >= 0)
                            {
                                counter++;
                                durationOfGreenLight = -1;
                                car.Dequeue();
                            }
                            else
                            {
                                string damagedCar = car.Peek();
                                char hitIndex = damagedCar[durationOfGreenLight + durationOfFreeWindow];
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{damagedCar} was hit at {hitIndex}.");                                
                                return;
                            }
                        }                       
                    }
                }

                else
                {
                    car.Enqueue(command);
                }
               
                command = Console.ReadLine();
            }            
        }
    }
}