namespace P01.GenericBoxOfString
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string content = Console.ReadLine();
                Box<string> boxWithString = new Box<string>(content);
                Console.WriteLine(boxWithString.ToString());
            }
        }
    }
}