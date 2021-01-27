using System;
using System.Collections.Generic;
using System.IO;

namespace SFApplication.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            const string Path = @"C:\Users\Alexey\source\repos\SFApplication\SFApplication.ConsoleApp\Students.dat";
            var students = DeserializeClass.DeserializeMeth<Student>(Path);
            Directory.CreateDirectory("D:\\StudentsOsp");

            foreach (var s in students)
            {
                if (!File.Exists($"D:\\StudentsOsp\\{s.Group}.txt"))
                {
                    using (StreamWriter sw = File.CreateText($"D:\\StudentsOsp\\{s.Group}.txt"))
                    {
                        sw.WriteLine("Имя:" + s.Name + " Дата рождения:" + s.DateOfBirth);
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(($"D:\\StudentsOsp\\{s.Group}.txt")))
                    {
                        sw.WriteLine("Имя:" + s.Name + " Дата рождения:" + s.DateOfBirth);
                    }
                }
            }
        }
    }
}
