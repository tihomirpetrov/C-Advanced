namespace P06.GenericCountMethodDoubles
{
    using System;
    using System.Collections.Generic;

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

            double element = double.Parse(Console.ReadLine());
            int count = GetCountOfGreaterElements<double>(box.Data, element);

            Console.WriteLine(count);

        }

        private static int GetCountOfGreaterElements<T>(List<T> listWithData, T element)
            where T: IComparable
        {
            int count = 0;

            foreach (var item in listWithData)
            {
                if (item.CompareTo(element) > 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}