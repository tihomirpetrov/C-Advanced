namespace P07.SoftUniParty
{
    using System;
    using System.Collections.Generic;

    class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            HashSet<string> vipGuests = new HashSet<string>();
            HashSet<string> regularGuests = new HashSet<string>();


            while (input != "END")
            {

                if (input == "PARTY")
                {
                    if (input.Length == 8)
                    {
                        if (input[0] == '1' || input[0] == '2' || input[0] == '3' || input[0] == '4' || input[0] == '5' || input[0] == '6' || input[0] == '7' || input[0] == '8' || input[0] == '9')
                        {
                            vipGuests.Add(input);
                        }
                        else
                        {
                            regularGuests.Add(input);
                        }
                    }
                    input = Console.ReadLine();

                }
                else
                {
                    input = Console.ReadLine();

                }

            }

            int count = vipGuests.Count + regularGuests.Count;
            Console.WriteLine(count);

            Console.WriteLine($"{string.Join(Environment.NewLine, vipGuests)}");
            Console.WriteLine($"{string.Join(Environment.NewLine, regularGuests)}");

        }
    }
}