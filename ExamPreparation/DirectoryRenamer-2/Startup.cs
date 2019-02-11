namespace DirectoryRenamer_2
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    public class Startup
    {
        public static void Main()
        {
            //string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string filePath = @"D:\test\";
            string[] directories = Directory.GetDirectories(filePath);
            //StringBuilder sb = new StringBuilder();
            //List<string> dirs = new List<string>(Directory.EnumerateDirectories(filePath));
            //Console.WriteLine(string.Join(Environment.NewLine, dirs));
            List<string> singleDir = new List<string>();
            List<string> newNames = new List<string>();

            foreach (var s in directories)
            {
                string directoryName = (s.Remove(0, filePath.Length));
                singleDir.Add(directoryName);
            }

            for (int i = 0; i < singleDir.Count; i++)
            {
                string tempName = singleDir[i].Split("___").ToString();
                string newName = (tempName[1] + tempName[0]).ToString();
                newNames.Add(newName);
            }

            Console.WriteLine(string.Join(Environment.NewLine, newNames));


            //for (int i = 0; i < directories.Length; i++)
            //{                
            //    string directoryName = directories[i];
            //    string[] singleDir = directoryName.Split(filePath, StringSplitOptions.RemoveEmptyEntries);
            //    string newDirectoryName = (singleDir[1] + singleDir[0]); 
            //}

            //string sourceDirectory = @"D:\test\";
            //string destinationDirectory = @"D:\test";

            //string newPath = Path.GetFullPath(fileName);
            //Directory.Move(source, destination);
        }
    }
}