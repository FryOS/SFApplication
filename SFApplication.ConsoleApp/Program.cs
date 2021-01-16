using System;
using System.Collections.Generic;
using System.IO;

namespace SFApplication.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // получим системные диски
            DriveInfo[] drives = DriveInfo.GetDrives();
            
            // Пробежимся по дискам и выведем их свойства
            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine($"Название: {drive.Name}");
                Console.WriteLine($"Тип: {drive.DriveType}");
                if (drive.IsReady)
                {
                    Console.WriteLine($"\tОбъем: {drive.TotalSize / (long)GBValues.GD} GB"); 
                    Console.WriteLine($"\tСвободно: {drive.TotalFreeSpace/ (long)GBValues.GD} GB");
                    Console.WriteLine($"\tМетка: {drive.VolumeLabel}");
                }
            }

            Console.ReadLine();
        }

        enum GBValues
        {
            KB = 1024,
            MB = 1048576,
            GD = 1073741824
        }

        class Drive
        {
            public Drive(string nameDisk, long totalSpaceDisk, long emptySpaceDisk)
            {
                this.nameDisk = nameDisk;
                this.totalSpaceDisk = totalSpaceDisk;
                this.emptySpaceDisk = emptySpaceDisk;
            }

            public string nameDisk;
            public long totalSpaceDisk;
            public long emptySpaceDisk;
        }

        public class Folder
        {
            public List<string> Files { get; set; } = new List<string>();

            Dictionary<string, Folder> Folders = new Dictionary<string, Folder>();

            public void CreateFolder(string name)
            {
                Folders.Add(name, new Folder());
            }
        }

        enum  GBValues 
        {
            KB = 1024,
            MB = 1048576,
            GD = 1073741824
        }
    }
}

