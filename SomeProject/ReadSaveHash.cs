using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SomeProject
{
    public static class ReadSaveHash
    {
        
        const string pathToHash = "../../../Hash.txt";
        public static string ReadHash()
        {
            FileStream fileStream = File.Open(pathToHash, FileMode.Open);
            string line;
            using (StreamReader reader = new StreamReader(fileStream))
            {
                line = reader.ReadLine();
                reader.Close();
            }
            fileStream.Close();
            Console.WriteLine($"SaveHashFile: {line}");
            return line;
        }
    }
}
