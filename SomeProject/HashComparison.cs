using System;
using System.Collections.Generic;
using System.Text;

namespace SomeProject
{
    public static class HashComparison
    {
        public static void Comparison(string filePath)
        {
            string fileHashValue = ReadHash.ReadFileHash(filePath);
            string saveFileHashValue = ReadSaveHash.ReadHash();

            if (saveFileHashValue != null)
            {
                bool result = Equals(fileHashValue, saveFileHashValue);
                switch (result)
                {
                    case true:
                        Console.WriteLine("Hashes are equal!");
                        break;
                    case false:
                        Console.WriteLine("Hashes are not equal!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("write file hash and try again!!!");
            }
        }
    }
}
