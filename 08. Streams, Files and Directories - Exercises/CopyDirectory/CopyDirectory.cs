﻿namespace CopyDirectory
{
    using System;
    using System.IO;

    public class CopyDirectory
    {
        static void Main()
        {
            string inputPath =  @$"{Console.ReadLine()}";
            string outputPath = @$"{Console.ReadLine()}";

            CopyAllFiles(inputPath, outputPath);
        }

        public static void CopyAllFiles(string inputPath, string outputPath)
        {
            DirectoryInfo inputDirectory = new DirectoryInfo(inputPath);
            DirectoryInfo outputDirectory = new DirectoryInfo(outputPath);

            if (outputDirectory.Exists)
            {
                outputDirectory.Delete(true);
            }

            outputDirectory.Create();

            foreach (FileInfo file in inputDirectory.GetFiles())
            {
                file.CopyTo($"{outputDirectory.FullName}\\{file.Name}");
            }
        }
    }
}
