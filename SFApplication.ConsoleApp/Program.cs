using System;
using System.IO;

namespace SFApplication.ConsoleApp
{
    class Program
    {
        const string PathTest = @"C:\Users\Alexey\source\repos\SFApplication\ToDel";
        const int MINUTES = 30;

        static void Main(string[] args)
        {
            Console.WriteLine("Введите путь до папки");
            var path =  Console.ReadLine();

            if (IsItemsExists(path))
            {
                DeleteFolderFiles(path);
            }
        }

        static bool IsItemsExists(string path)
        {
            if (Directory.Exists(path))
            {
                DirectoryInfo dirInfo = new DirectoryInfo(path);

                var folders = dirInfo.GetDirectories();
                var files = dirInfo.GetFiles();
                if (folders.Length == 0 && files.Length == 0)
                {
                    Console.WriteLine("Элементы не найдены");
                    return false;
                }
                return true;
            }
            else
            {
                Console.WriteLine("Указанный путь не найден");
                return false;
            }
        }

        static void DeleteFolderFiles(string path)
        {
            if (Directory.Exists(path))
            {
                DirectoryInfo dirInfo = new DirectoryInfo(path);

                var folders = dirInfo.GetDirectories();
                var files = dirInfo.GetFiles();
                try
                {
                    foreach (var item in files)
                    {
                        if (item.LastAccessTime + TimeSpan.FromMinutes(MINUTES) < DateTime.Now)
                        {
                            item.Delete();
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Произошла ошибка: " + ex.Message);
                }

                try
                {
                    foreach (var item in folders)
                    {
                        if (item.LastAccessTime + TimeSpan.FromMinutes(MINUTES) < DateTime.Now)
                        {
                            item.Delete(true);
                            Console.WriteLine($"{item} Удален");
                        }

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Произошла ошибка: " + ex.Message);
                }
            }
        }

    }
}
