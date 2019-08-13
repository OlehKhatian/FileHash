using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace SomeProject
{
    public class ReadHash
    {
        public static string ReadFileHash(string filePath)
        {
          
            var fileinfo = new FileInfo(filePath);
            if (fileinfo.Exists)
            {
                using (SHA256 sha = SHA256.Create())
                {
                    FileStream fileStream = fileinfo.Open(FileMode.Open);
                    byte[] hash = sha.ComputeHash(fileStream);

                    StringBuilder builder = new StringBuilder();
                    for (int i = 0; i < hash.Length; i++)
                    {
                        builder.Append(hash[i].ToString("x2"));
                    }
                    string hashFile = builder.ToString();
                   
                    fileStream.Close();
                    Console.WriteLine($"Hash file: {hashFile}");
                    return hashFile;                    
                }
            }
            else
            {
                return "Wrong file path!!!";
            }

        }
    }
}
