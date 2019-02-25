namespace P11.ParkingSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            Person tisho = new Person("tisho");
            Person ivan = new Person("ivan");

            int tishoAge = tisho.Age;
            int ivanAge = ivan.Age;
            

            if (tisho.Age == ivan.Age)
            {
                Console.WriteLine(tisho.Age);
            }
            else
            {
                Console.WriteLine(false);
            }

        }
    }
}
