namespace P06.FullDirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;

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

            string pathToDesktop = "";

            using (FileStream writer = new FileStream(" ", FileMode.Create))
            {

            }

            foreach (var kvp in extensionFileInfo)
            {
                string ext = kvp.Key;
                var info = kvp.Value;

                foreach (var fileInfo in info)
                {
                    string name = fileInfo.Name;
                    double size = fileInfo.Length / 1024;
                }
            }
        }
    }