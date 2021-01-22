using System;
using System.IO;

namespace SFApplication.ConsoleApp
{
    class Program
    {
        const string PathTest = @"C:\Users\Alexey\source\repos\SFApplication\ToDel";
        
        static void Main(string[] args)
        {
            Console.WriteLine("Введите директорию");
            var path = Console.ReadLine();

            if (IsItemsExists(path))
            {
                var size = GetFolderSize(path);
                Console.WriteLine($"Исходный размер папки {size}");
                DeleteFolderFiles(path);
                var sizeAfterDelete = GetFolderSize(path);
                Console.WriteLine($"Освобождено: {size}") ;
                Console.WriteLine($"Текущий размер папки: {sizeAfterDelete}");
            }
                        
            Console.ReadLine();
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
                        if (item.LastAccessTime + TimeSpan.FromMinutes(0) < DateTime.Now)
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
                        if (item.LastAccessTime + TimeSpan.FromMinutes(0) < DateTime.Now)
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

        static long GetFolderSize(string path)
        {
            long size = 0;
            if (Directory.Exists(path))
            {
                DirectoryInfo dirInfo = new DirectoryInfo(path);

                var folders = dirInfo.GetDirectories();
                var files = dirInfo.GetFiles();
                try
                {
                    foreach (var item in files)
                    {
                        size += item.Length;
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

                try
                {
                    foreach (var item1 in folders)
                    {
                        size += GetFolderSize(item1.FullName);
                    }
                    
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                return size;
            }
            else return size;
        }
    }
}
