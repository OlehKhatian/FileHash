using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Configuration;

namespace SomeProject
{
    
   static class Hash
    {
        public static void Run()
        {
            bool flag=true;
            while (flag)
            {
                Console.WriteLine("Select an action!");
                Console.WriteLine();
                Console.WriteLine("Press one to read the file hash");
                Console.WriteLine("Press two to save hash to file");
                Console.WriteLine("Press three to compare with the saved file hash");
                Console.WriteLine();
                Console.WriteLine("To exit from the program, press zero.");
               
                try
                {
                    int value = Convert.ToInt32(Console.ReadLine());
                    switch (value)
                    {
                        case 1:
                            Console.WriteLine("Please enter the file path!");
                            string filePathRead = Console.ReadLine();
                            ReadHash.ReadFileHash(filePathRead);
                            Console.WriteLine(new string('-',70));
                            break;
                        case 2:
                            Console.WriteLine("Please enter the file path!");
                            string filePathWrite = Console.ReadLine();
                            WriteHash.WriteHashFile(filePathWrite);
                            Console.WriteLine(new string('-', 70));
                            break;
                        case 3:
                            Console.WriteLine("Please enter the file path!");
                            string filePathCompare = Console.ReadLine();
                            HashComparison.Comparison(filePathCompare);
                            Console.WriteLine(new string('-', 70));
                            break;
                        case 0:
                            flag = false;
                            break;
                        
                    }
                }
                catch
                {
                    Console.WriteLine("You have entered a wrong value. Please try again!");
                    Console.WriteLine(new string('-',70));
                    Console.WriteLine();
                }
            }
        }

    }

}
