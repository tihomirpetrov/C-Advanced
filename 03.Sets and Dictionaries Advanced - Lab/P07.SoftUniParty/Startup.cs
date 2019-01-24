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
            bool isParty = false;
            while (input != "END")
            {
                if (input == "PARTY")
                {
                    isParty = true;
                    input = Console.ReadLine();
                }

                if (input.Length == 8 && isParty == false)
                {
                    if (input[0] == '1' || input[0] == '2' || input[0] == '3' || input[0] == '4' || input[0] == '5' || input[0] == '6' || input[0] == '7' || input[0] == '8' || input[0] == '9')
                    {
                        if (!vipGuests.Contains(input))
                        {
                            vipGuests.Add(input);
                        }
                    }
                    else
                    {
                        if (!regularGuests.Contains(input))
                        {
                            regularGuests.Add(input);
                        }
                    }
                }
                
                else if(isParty)
                {              
                    if (vipGuests.Contains(input))
                    {
                        vipGuests.Remove(input);
                    }
                    else if (regularGuests.Contains(input))
                    {
                        regularGuests.Remove(input);
                    }
                }

                input = Console.ReadLine();
            }

            int count = vipGuests.Count + regularGuests.Count;
            Console.WriteLine(count);

            Console.WriteLine($"{string.Join(Environment.NewLine, vipGuests)}");
            Console.WriteLine($"{string.Join(Environment.NewLine, regularGuests)}");

        }
    }
}