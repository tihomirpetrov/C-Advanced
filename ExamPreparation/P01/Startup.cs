namespace P01.ClubParty
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            int maxCapacity = int.Parse(Console.ReadLine());
            Stack<string> input = new Stack<string>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries));
            Queue<string> halls = new Queue<string>();
            Queue<int> people = new Queue<int>();
            int allPeople = 0;
            List<int> peopleList = new List<int>();

            while (input.Count > 0)
            {
                string temp = input.Pop();
                bool isNumber
            }


        }
    }
}