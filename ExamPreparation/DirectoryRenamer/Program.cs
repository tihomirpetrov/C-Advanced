namespace DirectoryRenamer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            Console.Write("Enter number of folders: ");
            int numberOfFolders = int.Parse(Console.ReadLine());
            string[] directoryNames = new string[numberOfFolders];
            List<char> directory = new List<char>();
            StringBuilder sb = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();

            string input = Console.ReadLine();

            while (input != "enough")
            {
                int counter = 0;
                

                for (int i = 0; i < numberOfFolders; i++)
                {
                    for (int j = 0; j < input.Length; j++)
                    {
                        if (input[j] == '_')
                        {
                            counter++;
                        }
                        if (counter == 3)
                        {
                            int index = j;
                            for (int k = index; k < input.Length; k++)
                            {
                                directory.Add(input[index]);
                            }
                            sb2 = sb;
                            counter = 0;
                            sb.Clear();
                        }

                        sb.Append(input[j]);
                    }

                    //for (int j = tokens.Length - 1; j >= 0; j--)
                    //{
                    //}
                }

                input = Console.ReadLine();
            }

            Console.Write(sb2);
            Console.WriteLine(string.Join("", directory));
            //Console.Write(string.Join("", directory));
        }
    }
}