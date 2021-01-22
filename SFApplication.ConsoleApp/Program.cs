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
            var TotalSize = GetFolderSize(path);
            Console.WriteLine($"{TotalSize} байт");
            Console.WriteLine($"{TotalSize / Math.Pow(1024, 1):f2} KB");
            Console.WriteLine($"{TotalSize / Math.Pow(1024, 2)} MB");
            
            Console.ReadLine();

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
