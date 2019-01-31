namespace P03.CountUppercaseWords
{
    using System;
    using System.Linq;
   
    public class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            var upperCaseWords = input.Split(' ').Where(x => !string.IsNullOrEmpty(x) && char.IsUpper(x[0]));          

            foreach (var item in upperCaseWords)
            {
                Console.WriteLine(item);
            }            
        }
    }
}