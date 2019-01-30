namespace P04.CopyBinaryFile
{
    using System;
    using System.IO;

    class Startup
    {
        public static void Main()
        {
            using (FileStream reader = new FileStream(@"..\..\..\copyMe.png", FileMode.Open))
            {
                using (FileStream writer = new FileStream(@"..\..\..\copied.png", FileMode.Create))
                {
                    while (true)
                    {
                        byte[] buffer = new byte[4096];

                        int byteSize = reader.Read(buffer, 0, buffer.Length);

                        if (byteSize < 1)
                        {
                            break;
                        }

                        writer.Write(buffer, 0, byteSize);
                    }
                }
            }
        }
    }
}