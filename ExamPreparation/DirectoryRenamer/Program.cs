namespace DirectoryRenamer
{
    using System;
    using System.IO;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            DirectoryInfo directoryPath = new DirectoryInfo(@"d:\test");

            foreach (var child in directoryPath.GetDirectories())
            {
                string name = child.FullName;
                string pattern = @"(?<=\\)(\d+\w+)";
                MatchCollection matchName = Regex.Matches(name, pattern);
                foreach (Match item in matchName)
                {
                    string[] originalName = item.ToString().Split("___");
                    string newName = $"{originalName[1]}___{originalName[0]}";
                    string newNamePath = $@"d:\test\{newName}";
                    Directory.Move(name, newNamePath);
                }
            }
        }
    }
}