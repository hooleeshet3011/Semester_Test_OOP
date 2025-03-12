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
            int[] B = { 29, 19, 2, 3 }; // last 4 digits 10418.9712

            FileSystem files = new FileSystem();

            // Add B0 files
            for (int i = 0; i < B[0]; i++)
            {
                files.Add(new Demo_Test.File($"1119270-{i}", "txt", 100)); // Assume each file contains 100 bytes
            }

            // Folder that contains B[1] files
            Folder folder1 = new Folder("Folder1");
            for (int i = 0; i < B[1]; i++)
            {
                folder1.Add(new Demo_Test.File($"1119270-{i}", "txt", 100));
            }
            files.Add(folder1);

            Folder folder2 = new Folder("Folder2");
            Folder subFolder = new Folder("SubFolder");
            for (int i = 0; i < B[2]; i++)
            {
                subFolder.Add(new Demo_Test.File($"1119270-{i}", "txt", 100));
            }
            folder2.Add(subFolder);
            files.Add(folder2);

            // Empty folders
            for (int i = 0; i < B[3]; i++)
            {
                files.Add(new Folder($"EmptyFolder{i}"));
            }

            files.PrintContents();
        }
    }
}
