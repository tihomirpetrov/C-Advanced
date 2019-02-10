namespace P06.GenericCountMethodDoubles
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Box<double> box = new Box<double>();

            for (int i = 0; i < n; i++)
            {
                double line = double.Parse(Console.ReadLine());
                box.Add(line);
            }



        }
    }
}