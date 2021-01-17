using System;
using System.Collections.Generic;
using System.IO;

namespace SFApplication.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileInfo = new FileInfo(@"C:/Users/Alexey/source/repos/SFApplication/SFApplication.ConsoleApp/Program.cs");

            using (StreamWriter sw = fileInfo.AppendText())
            {
                sw.WriteLine($"// Время запуска: {DateTime.Now}");
            }

            using (StreamReader sr = fileInfo.OpenText())
            {
                string str = "";
                while ((str = sr.ReadLine()) != null)
                    Console.WriteLine(str);

            }
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

        static void ReadFile()
        {
            string filePath = @"C:/Users/Alexey/source/repos/SFApplication/SFApplication.ConsoleApp/Program.cs";
            // Укажем путь 
            if (File.Exists(filePath)) // Проверим, существует ли файл по данному пути
            {
                var time = DateTime.Now;
                FileInfo fi = new FileInfo(@"C:/Users/Alexey/source/repos/SFApplication/SFApplication.ConsoleApp/Program.cs");
                using (StreamWriter sw = fi.AppendText())
                {
                    sw.WriteLine("//" + time);
                }

                using (StreamReader sr = File.OpenText(filePath))
                {
                    string str = "";
                    while ((str = sr.ReadLine()) != null) // Пока не кончатся строки - считываем из файла по одной и выводим в консоль
                    {
                        Console.WriteLine(str);
                    }
                }
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


//17.01.2021 18:42:28
//17.01.2021 18:42:38
// Время запуска: 17.01.2021 18:44:56
