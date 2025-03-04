﻿using System;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantity = double.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());

            Car firstCar = new Car();
            Car secondCar = new Car(make, model, year);
            Car thirdCar = new Car(make, model, year, fuelQuantity, fuelConsumption);

            Console.WriteLine(firstCar);
            Console.WriteLine(secondCar);
            Console.WriteLine(thirdCar);

            GenerateZip();
        }

        public static void GenerateZip()
        {
            string fileName = $"..\\..\\..\\{Assembly.GetExecutingAssembly().FullName.Split(',')[0]}.zip";

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            FileInfo[] files = new DirectoryInfo(@"..\..\..\").GetFiles();

            using (var archive = ZipFile.Open(fileName, ZipArchiveMode.Create))
            {
                foreach (FileInfo file in files)
                {
                    archive.CreateEntryFromFile(file.FullName, file.Name);
                }
            }
        }
    }
}
