using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Win32.SafeHandles;

namespace SomeProject
{
   public static class WriteHash
    {
        const string pathToHash = "../../../Hash.txt";
        
        public static string WriteHashFile(string filePath)
        {
            var fileInfo = new FileInfo(filePath);
            if (fileInfo.Exists)
            {
                    string hashvalue= ReadHash.ReadFileHash(filePath);
                    FileStream fileStream = fileInfo.Open(FileMode.OpenOrCreate);
                    var fileHash = new FileStream(pathToHash, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                    var write = new StreamWriter(fileHash);
                    write.Write(hashvalue);
                    write.Close();
                    fileStream.Close();
                    Console.WriteLine($"Open file {fileInfo.FullName} and save hash in file {new FileInfo(pathToHash).FullName}");
                
                return hashvalue;
            }
            else
            {
                return "Wrong file path !!!";
            }
            
        }
    }
}
