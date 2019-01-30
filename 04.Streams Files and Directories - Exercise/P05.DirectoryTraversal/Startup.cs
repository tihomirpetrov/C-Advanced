namespace P05.DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    class Startup
    {
        public static void Main()
        {
            string path = Console.ReadLine();

            var files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);

            Dictionary<string, List<FileInfo>> extensionFileInfo = new Dictionary<string, List<FileInfo>>();

            foreach (var file in files)
            {
                FileInfo info = new FileInfo(file);

                if (!extensionFileInfo.ContainsKey(info.Extension))
                {
                    extensionFileInfo[info.Extension] = new List<FileInfo>();
                }

                extensionFileInfo[info.Extension].Add(info);
            }

            using (StreamWriter writer = new StreamWriter(@"..\..\..\Report.txt"))
            {
                foreach (var kvp in extensionFileInfo.OrderBy(x => x.Value.Count).ThenBy(x => x.Key))
                {
                    string ext = kvp.Key;
                    var info = kvp.Value;
                    writer.WriteLine(ext);

                    foreach (var fileInfo in info.OrderByDescending(x => x.Length))
                    {
                        string name = fileInfo.Name;
                        double size = fileInfo.Length * 1.0 / 1024 * 1.0;

                        writer.WriteLine($"--{name} - {size:f3}");
                    }
                }
            }
        }
    }
}