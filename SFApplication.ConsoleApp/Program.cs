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
            Console.WriteLine("-------------------------------------");
            GetCatalogs();
            Console.WriteLine("-------------------------------------");
            int a = GetValueDirFiles();
            Console.WriteLine(a);
            Console.ReadLine();
        }

        enum GBValues
        {
            KB = 1024,
            MB = 1048576,
            GD = 1073741824
        }

        static int GetValueDirFiles()
        {
            int value = 0;
            string dirName = @"/"; // 
            if (Directory.Exists(dirName))
            {
                string[] dirs = Directory.GetDirectories(dirName);
                string[] files = Directory.GetFiles(dirName);
                var valueDir = dirs.Length;
                var valueFiles = files.Length;
                value = valueDir + valueFiles;
                return value;
            }
            return value;
        }

        static void GetCatalogs()
        {
            string dirName = @"/"; // Прописываем путь к корневой директории MacOS (для Windows скорее всего тут будет "C:\\")
            if (Directory.Exists(dirName)) // Проверим, что директория существует
            {
                Console.WriteLine("\tПапки:");
                string[] dirs = Directory.GetDirectories(dirName);  // Получим все директории корневого каталога

                foreach (string d in dirs) // Выведем их все
                    Console.WriteLine(d);

                Console.WriteLine();
                Console.WriteLine("\tФайлы:");
                string[] files = Directory.GetFiles(dirName);// Получим все файлы корневого каталога

                foreach (string s in files)   // Выведем их все
                    Console.WriteLine(s);
            }
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

        
    }
}

