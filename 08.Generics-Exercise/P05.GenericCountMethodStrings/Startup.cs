namespace P05.GenericCountMethodStrings
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                box.Add(line);
            }

            string element = Console.ReadLine();

            int count = GetCountOfGreaterElements<string>(box.Data, element);

            Console.WriteLine(count);
        }
        public static int GetCountOfGreaterElements<T>(List<T> listWithData, T element)
            where T : IComparable
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