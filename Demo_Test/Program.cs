// See https://aka.ms/new-console-template for more information
using Demo_Test;
using System;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            int[] A = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
            int[] B = { 29, 19, 2, 3 }; // last 4 digit 10418.9712

            FileSystem fs = new FileSystem();

            // Adding B[0] files
            for (int i = 0; i < B[0]; i++)
            {
                fs.Add(new Demo_Test.File($"1119270-{i}", "txt", 100)); // Assume each file contains 100 bytes
            }

            // Adding a folder that contains B[1] files
            Folder folder1 = new Folder("Folder1");
            for (int i = 0; i < B[1]; i++)
            {
                folder1.Add(new Demo_Test.File($"1119270-{i}", "txt", 100));
            }
            fs.Add(folder1);

            // Adding a folder that contains a folder that contains B[2] files
            Folder folder2 = new Folder("Folder2");
            Folder subFolder = new Folder("SubFolder");
            for (int i = 0; i < B[2]; i++)
            {
                subFolder.Add(new Demo_Test.File($"1119270-{i}", "txt", 100));
            }
            folder2.Add(subFolder);
            fs.Add(folder2);

            // Adding B[3] empty folders
            for (int i = 0; i < B[3]; i++)
            {
                fs.Add(new Folder($"EmptyFolder{i}"));
            }

          
            fs.PrintContents();
        }
    }

}
